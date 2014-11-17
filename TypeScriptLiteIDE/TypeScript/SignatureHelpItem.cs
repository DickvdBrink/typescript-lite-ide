namespace TypeScriptLiteIDE.TypeScript
{
    public class SignatureHelpItem
    {
        bool isVariadic;
        SymbolDisplayPart[] prefixDisplayParts;
        SymbolDisplayPart[] suffixDisplayParts;
        SymbolDisplayPart[] separatorDisplayParts;
        SignatureHelpParameter[] parameters;
        SymbolDisplayPart[] documentation;
    }
}