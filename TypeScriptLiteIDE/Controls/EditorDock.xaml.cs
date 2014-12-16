using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;

namespace TypeScriptLiteIDE.Controls
{
    /// <summary>
    /// Interaction logic for EditorDock.xaml
    /// </summary>
    public partial class EditorDock : UserControl
    {
        public EditorDock()
        {
            InitializeComponent();
        }

        public void OpenFile(string filename)
        {
            TSEditor content = new TSEditor(Path.GetFileName(filename), File.ReadAllText(filename));
            documentPane.Children.Add(content);
        }
    }
}
