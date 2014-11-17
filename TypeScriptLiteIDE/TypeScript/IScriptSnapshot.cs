namespace TypeScriptLiteIDE.TypeScript
{
    interface IScriptSnapshot
    {
        string getText(int start, int end);
        int getLength();
        int[] getLineStartPositions();
        TextChangeRange getChangeRange(IScriptSnapshot oldSnapshot);
    }
}