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

namespace WPFOrg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click_1(object sender, RoutedEventArgs e)
        {
            VMRpo vmrpo = this.Resources["rps"] as VMRpo;
            Rpo r = new Rpo("haha");
            vmrpo.RpoCollection.Add(r);
            vmrpo.Rpos.View.MoveCurrentTo(r);
        }
    }
}
