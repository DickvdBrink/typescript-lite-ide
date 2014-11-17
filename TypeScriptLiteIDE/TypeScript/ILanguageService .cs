using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScriptLiteIDE.TypeScript
{
    interface ILanguageService
    {
        void cleanupSemanticCache();
        Diagnostic[] getSyntacticDiagnostics(string fileName);
        Diagnostic[] getSemanticDiagnostics(string fileName);
        Diagnostic[] getCompilerOptionsDiagnostics();
        ClassifiedSpan[] getSyntacticClassifications(string fileName, TypeScript.TextSpan span);
        ClassifiedSpan[] getSemanticClassifications(string fileName, TypeScript.TextSpan span);
        CompletionInfo getCompletionsAtPosition(string fileName, int position, bool isMemberCompletion);
        CompletionEntryDetails getCompletionEntryDetails(string fileName, int position, string entryName);
        QuickInfo getQuickInfoAtPosition(string fileName, int position);
        TypeScript.TextSpan getNameOrDottedNameSpan(string fileName, int startPos, int endPos);
        TypeScript.TextSpan getBreakpointStatementAtPosition(string fileName, int position);
        SignatureHelpItems getSignatureHelpItems(string fileName, int position);
        SignatureInfo getSignatureAtPosition(string fileName, int position);
        RenameInfo getRenameInfo(string fileName, int position);
        RenameLocation[] findRenameLocations(string fileName, int position, bool findInStrings, bool findInComments);
        DefinitionInfo[] getDefinitionAtPosition(string fileName, int position);
        ReferenceEntry[] getReferencesAtPosition(string fileName, int position);
        ReferenceEntry[] getOccurrencesAtPosition(string fileName, int position);
        ReferenceEntry[] getImplementorsAtPosition(string fileName, int position);
        NavigateToItem[] getNavigateToItems(string searchValue);
        NavigationBarItem[] getNavigationBarItems(string fileName);
        OutliningSpan[] getOutliningSpans(string fileName);
        TodoComment[] getTodoComments(string fileName, TodoCommentDescriptor[] descriptors);
        TypeScript.TextSpan[] getBraceMatchingAtPosition(string fileName, int position);
        int getIndentationAtPosition(string fileName, int position, EditorOptions options);
        TextChange[] getFormattingEditsForRange(string fileName, int start, int end, FormatCodeOptions options);
        TextChange[] getFormattingEditsForDocument(string fileName, FormatCodeOptions options);
        TextChange[] getFormattingEditsAfterKeystroke(string fileName, int position, string key, FormatCodeOptions options);
        EmitOutput getEmitOutput(string fileName);
        void dispose();
    }
}
