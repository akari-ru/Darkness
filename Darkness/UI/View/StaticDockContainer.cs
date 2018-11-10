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
    public class StaticDockContainer : DockContainer
    {
        public StaticDockContainer()
        {
            var headerLabel = new Label();
            headerLabel.Content = "Output";

            var tabItem = new TabItem();
            tabItem.Header = headerLabel;

            var label = new Label();
            label.Foreground = Brushes.Lime;
            label.VerticalAlignment = VerticalAlignment.Center;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.FontSize = 20;
            label.Content = "Hello StaticDockContainer";

            tabItem.Content = label;

            Items.Add(tabItem);
        }
    }
}
