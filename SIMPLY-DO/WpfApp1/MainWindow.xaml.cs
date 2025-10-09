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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int taskCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void buttonAdd_click(object sender, RoutedEventArgs e)
        {
            
            if(!string.IsNullOrEmpty(txtTasks.Text) && !listTasks.Items.Contains(txtTasks))
            {
                taskCount++;
                listTasks.Items.Add(taskCount.ToString() + ": " + txtTasks.Text);
                txtTasks.Clear();
            }
        }

        private void buttonClear_click(object sender, RoutedEventArgs e)
        {
            if(listTasks.Items.Count > 0)
            {
                listTasks.Items.Clear();
                taskCount = 0; 
            }
        }
    }
}
