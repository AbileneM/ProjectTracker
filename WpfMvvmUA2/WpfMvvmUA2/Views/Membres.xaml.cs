using System;
using System.Collections.Generic;
using System.Windows.Controls;
using WpfMvvmUA2.ViewModel;



namespace WpfMvvmUA2.Views
{
    /// <summary>
    /// Logique d'interaction pour Membres.xaml
    /// </summary>
    public partial class Membres : Page
    {
        public Membres()
        {
            InitializeComponent();

            MembreViewModel membreViewModel = new MembreViewModel();
            this.DataContext = membreViewModel;
        }
    }
}
