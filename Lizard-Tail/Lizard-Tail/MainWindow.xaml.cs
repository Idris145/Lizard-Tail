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
using Lizard_Tail.ViewModel;
using Lizard_Tail.Model;

namespace Lizard_Tail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HomePageViewModel hp = new HomePageViewModel();
            var x = new App_Model();
            hp.LoginButtonText = "Register";
            this.HomePage.DataContext = hp;
        }
    }
}
