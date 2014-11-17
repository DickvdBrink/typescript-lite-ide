using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScriptLiteIDE.TypeScript
{
    interface ILanguageServiceHost
    {
        CompilerOptions getCompilationSettings();
        string[] getScriptFileNames();
        string getScriptVersion(string fileName);
        bool getScriptIsOpen(string fileName);
        TypeScript.IScriptSnapshot getScriptSnapshot(string fileName);
        object getLocalizedDiagnosticMessages();
        ICancellationToken getCancellationToken();
        string getCurrentDirectory();
        string getDefaultLibFilename();
    }
}
