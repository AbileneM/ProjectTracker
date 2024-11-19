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
using System.Windows.Shapes;
using WpfMvvmUA2.ViewModel;

namespace WpfMvvmUA2.Views
{
    /// <summary>
    /// Logique d'interaction pour AddMembre.xaml
    /// </summary>
    public partial class AddMembre : Window
    {
        public AddMembre()
        {
            InitializeComponent();
            AddMembreViewModel viewModel = new AddMembreViewModel();
            this.DataContext = viewModel;

            // Définit l'action CloseAction pour fermer la fenêtre
            viewModel.CloseAction = new Action(this.Close);

        }
    }
}
