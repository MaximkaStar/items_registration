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
using System.IO;

namespace items_registration
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private object Txb { get; set; }

        public Login()
        {
            InitializeComponent();
        }
        public void AddItemButtonClick()
        {
            File.WriteAllText();
        }
        public void ReadItemButtonCLick()
        {
            File.OpenText();
        }
    }
}
