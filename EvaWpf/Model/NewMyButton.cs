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

namespace EvaWpf.Model
{
    class NewMyButton : Button
    {
        public void CreatButton(Button buttons, string str, int x, int y, int w, int h, RoutedEventHandler revh)
        {
            buttons = new Button();
            buttons.Content = str;
            buttons.Margin = new Thickness(x, y, 0, 0);
            buttons.Width = 50;
            buttons.Height = 20;
            buttons.Click += revh;
        }
    }
}
