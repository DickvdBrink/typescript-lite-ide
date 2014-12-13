using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TypeScriptLiteIDE.Controls
{
    /// <summary>
    /// Interaction logic for ProjectExplorer.xaml
    /// </summary>
    public partial class ProjectExplorer : UserControl
    {
        public interface AbstractNode
        {

        }

        private List<AbstractNode> nodes = new List<AbstractNode>();
        public List<AbstractNode> Nodes
        {
            get { return nodes; }
        }

        public ProjectExplorer()
        {
            InitializeComponent();

            DataContext = this;
        }
    }

    
}
