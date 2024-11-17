using System;
using System.Collections.Generic;
using System.Windows.Controls;
using WpfMvvmUA2.Views.Controls;



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
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMenu = sidebar.SelectedItem as NavButton;

            navframe.Navigate(selectedMenu.Navlink);

            
        }
    }
}
