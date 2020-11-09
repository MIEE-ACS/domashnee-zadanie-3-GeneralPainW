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

namespace Home_Work_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public struct Shoes
        {
            private int main_article;
            public int article
            {
                set
                {
                    if (article > 0 && article < 1001)
                    {
                        main_article = article;
                    }
                }
                get
                {
                    return main_article;
                }
            }
            private int main_size;
            public int size
            {
                set
                {
                    if (size > 34 && size < 45)
                    {
                        main_size = size;
                    }
                }
                get
                {
                    return main_size;
                }
            }
            private int main_cost;
            public int cost
            {
                set
                {
                    if (cost > 0 && cost < 100000)
                    {
                        main_cost = cost;
                    }
                }
                get
                {
                    return main_cost;
                }
            }
            private string main_title;
            public string title
            {
                set
                {
                    if (title != "")
                    {
                        main_title = title;
                    }
                }
                get
                {
                    return main_title;
                }
            }
        }
    }
}
