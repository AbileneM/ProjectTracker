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
using WpfMvvmUA2.ViewModel;

namespace WpfMvvmUA2.Views
{
    /// <summary>
    /// Logique d'interaction pour Projets.xaml
    /// </summary>
    public partial class Projets : Page
    {
        public Projets()
        {
            InitializeComponent();

            ProjetsViewModel projetViewModel = new ProjetsViewModel();
            this.DataContext = projetViewModel;
        }
    }
}
