# Vantum.AppKit - AI Coding Instructions

## Purpose

NuGet library providing .NET attributes for Vantum ERP's manifest-driven architecture. Controllers annotated with these attributes have their routes/permissions auto-extracted into `manifest.json` at runtime.

## Build & Publish

```bash
dotnet build                       # Build library
dotnet pack                        # Create NuGet package
# Publish via GitHub Actions workflow: .github/workflows/publish-nuget.yml
```

## Core Attributes

| Attribute | Purpose | Required |
|-----------|---------|----------|
| `[AppBelongsTo("AppName")]` | Links controller to an app manifest | Yes, on all controllers |
| `[AppRouteAuto]` | Auto-extracts HTTP method/path from ASP.NET attributes | Common |
| `[AppRoute]` | Explicit route definition (method, path, permission) | Alternative |
| `[AppMigration]` | Marks EF migrations for app-specific tracking | On migrations |
| `[AppWorkflow]` | Defines workflow metadata | On workflow classes |
| `[WorkflowAction]` | Defines workflow step actions | On workflow methods |

## Attribute Usage Pattern

```csharp
using Vantum.AppKit;

[ApiController]
[Route("api/contacts")]
[AppBelongsTo("Contacts")]                           // Required: links to apps/Contacts/
[AppPublishesEvents("Contact.Created", "Contact.Updated")]
public class ContactsController : ControllerBase
{
    [HttpPost]
    [AppRouteAuto(
        RequiredPermissions = new[] { "Contacts.Create" },
        PublishesEvents = new[] { "Contact.Created" }
    )]
    public async Task<IActionResult> Create([FromBody] CreateContactDto dto) { }
}
```

## Adding New Attributes

1. Create attribute class inheriting `Attribute`:
```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class YourNewAttribute : Attribute
{
    public string Key { get; }
    public YourNewAttribute(string key) => Key = key;
}
```

2. Document in README.md with usage example

## Integration Points

- **Runtime scanning**: `ManifestAugmentationService` in vantumerp scans these attributes in dev mode
- **CLI extraction**: `vantum generate workflows` reads `[AppWorkflow]`/`[WorkflowAction]` from compiled assemblies
- **Manifest updates**: Scanned data merges into `apps/{AppName}/manifest.json`

## Key Design Principles

- Keep attributes simple (data carriers only, no logic)
- Support both class-level and method-level where appropriate
- Use string arrays for multi-value properties (permissions, events)
- Provide override properties (`MethodOverride`, `PathOverride`) for edge cases
