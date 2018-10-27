using System;
using System.Collections.Generic;
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

namespace Darkness.UI.View
{
    /// <summary>
    /// Interaction logic for Workspace.xaml
    /// </summary>
    public partial class Workspace : UserControl
    {

        List<string> dataList = new List<string>() { "Hello", "World" };

        public Workspace()
        {
            InitializeComponent();
        }

        public List<string> DataList { get => dataList; set => dataList = value; }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Add(textBox1.Text);
        }
    }
}
