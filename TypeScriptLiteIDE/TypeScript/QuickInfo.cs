namespace TypeScriptLiteIDE.TypeScript
{
    public class QuickInfo
    {
        string kind;
        string kindModifiers;
        TypeScript.TextSpan textSpan;
        SymbolDisplayPart[] displayParts;
        SymbolDisplayPart[] documentation;
    }
}