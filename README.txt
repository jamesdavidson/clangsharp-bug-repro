ClangSharp gets caught up on the semantics of uint64 on Linux.

Warning: Unsupported bitfield type: 'Builtin'. Generated bindings may be incomplete.

It still produces C# code but that code fails to compile because it puts 0x1 where it needs 0x1UL.

Error: Cannot apply operator '&' to operands of type 'ulong' and 'int'

I can see two options
 - pre-process msquic.h with sed to use "unsigned long long" instead of "uint64_t"
 - ignore warnings and post-process generated C# to replace 0x1 with 0x1UL

Related:
https://github.com/dotnet/ClangSharp/issues/401
https://github.com/dotnet/ClangSharp/issues/574

However, after all this, in the case of MsQuic it turns out that the generated C# is equivalent across all three operating systems (modulo the different NativeTypeNameAttributes which I'm not using anyway). This was a surprise because there are comments in msquic_posix.h like "// 125  (89 on macOS)". So there you go.

I also discovered that at some point (circa .NET 6) there was already a generate-dotnet.ps1 script for invoking ClangSharpPInvokeGenerator but it seems that it has not been maintained.
