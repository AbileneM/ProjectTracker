using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Views;
using WpfMvvmUA2.Views.Controls;

namespace WpfMvvmUA2.ViewModel
{
    public class MembreViewModel
    {
            public ObservableCollection<Membre> Membres { get; set; }
            public ICommand ShowAddMembreWindow { get; set; }
            public ICommand DeleteMembre { get; set; }

            private ICollectionView _filteredMembres;
             public ICollectionView FilteredMembres
             {
               get { return _filteredMembres; }
               set { _filteredMembres = value; OnPropertyChanged(nameof(FilteredMembres)); }
             }

             private string _filterText;
             public string FilterText
             {
               get { return _filterText; }
               set
               {
                   _filterText = value;
                   OnPropertyChanged(nameof(FilterText));
                   FilteredMembres.Refresh(); // Rafraîchit le filtre
               }
             }
              public event PropertyChangedEventHandler PropertyChanged;
              private void OnPropertyChanged(string propertyName)
              {
                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
              }
              public MembreViewModel()
              {
                Membres = MembreManager.GetMembres();
                ShowAddMembreWindow = new MyICommand(ExcuteShowAddMembreWindow, CanExcuteShowAddMembreWindow);
                DeleteMembre = new MyICommand(ExcuteDeleteMembre, CanExcuteDeleteMembre);

                FilteredMembres = CollectionViewSource.GetDefaultView(Membres);
                FilteredMembres.Filter = FilterMembres; // Associe la fonction de filtrage
              }
        private bool FilterMembres(object item)
        {
            if (item is Membre membre)
            {
                return string.IsNullOrEmpty(FilterText) ||
                       membre.Nom.Contains(FilterText, StringComparison.OrdinalIgnoreCase) ||
                       membre.Prenom.Contains(FilterText, StringComparison.OrdinalIgnoreCase) ||
                       membre.Role.Contains(FilterText, StringComparison.OrdinalIgnoreCase) ||
                       membre.Email.Contains(FilterText, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        private bool CanExcuteDeleteMembre(object obj)
        {
            // Vérifie que l'objet n'est pas nul et est de type Client
            return obj is Membre;
        }

        private void ExcuteDeleteMembre(object obj)
        {
            if (obj is Membre membreToDelete)
            {
                // Afficher une boîte de dialogue de confirmation
                var result = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer {membreToDelete.Prenom} {membreToDelete.Nom} ?",
                    "Confirmation de suppression",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning);

                // Si l'utilisateur clique sur "OK", on supprime le membre
                if (result == MessageBoxResult.OK)
                {
                    Membres.Remove(membreToDelete);
                }
            }
        }

        private bool CanExcuteShowAddMembreWindow(object obj)
        {
           return true;
        }
        private void ExcuteShowAddMembreWindow(object obj)
        {
          AddMembre addMembre = new AddMembre();
          addMembre.Show();
        }
    }
}
