#if NETSTANDARD2_1
// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

/// <summary>
/// Polyfill for init-only properties in .NET Standard 2.1
/// </summary>
internal static class IsExternalInit { }
#endif
