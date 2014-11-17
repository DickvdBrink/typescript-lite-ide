namespace TypeScriptLiteIDE.TypeScript
{
    public enum EmitReturnStatus
    {
        Succeeded = 0,
        AllOutputGenerationSkipped = 1,
        JSGeneratedWithSemanticErrors = 2,
        DeclarationGenerationSkipped = 3,
        EmitErrorsEncountered = 4,
        CompilerOptionsErrors = 5,
    }
}