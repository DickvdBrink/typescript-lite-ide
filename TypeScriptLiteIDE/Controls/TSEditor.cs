using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Xceed.Wpf.AvalonDock.Layout;

namespace TypeScriptLiteIDE.Controls
{
    class TSEditor : LayoutDocument
    {

        public TSEditor(string title, string content)
        {
            Title = title;

            TextEditor editor = new TextEditor();
            editor.ShowLineNumbers = true;
            editor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("JavaScript");
            editor.Text = content;
            Content = editor;
        }
    }
}
