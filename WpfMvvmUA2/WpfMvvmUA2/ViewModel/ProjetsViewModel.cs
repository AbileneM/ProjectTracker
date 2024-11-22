using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Views;

namespace WpfMvvmUA2.ViewModel
{
    class ProjetsViewModel
    {

        public ObservableCollection<Projet> Projets { get; set; }
        public ICommand ShowWindow { get; set; }

        private ICollectionView _filteredProjets;
        public ICollectionView FilteredProjets
        {
            get { return _filteredProjets; }
            set { _filteredProjets = value; OnPropertyChanged(nameof(FilteredProjets)); }
        }

        private string _filterText;
        public string FilterText
        {
            get { return _filterText; }
            set
            {
                _filterText = value;
                OnPropertyChanged(nameof(FilterText));
                FilteredProjets.Refresh(); // Rafraîchit le filtre chaque fois que vous changez le texte du filtre
            }
        }

        public ProjetsViewModel()
        {
            Projets = ProjetManager.GetProjets();
            ShowWindow = new MyICommand(ExcuteShowWindow, CanExcuteShowWindow);

            // Initialiser la vue filtrée des projets
            FilteredProjets = CollectionViewSource.GetDefaultView(Projets);
            FilteredProjets.Filter = FilterProjets; // Associer la fonction de filtrage
        }

        private bool FilterProjets(object item)
        {
            if (item is Projet projet)
            {
                return string.IsNullOrEmpty(FilterText) ||
                       projet.Titre.Contains(FilterText, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }


        private bool CanExcuteShowWindow(object obj)
        {
            return true;
        }
        private void ExcuteShowWindow(object obj)
        {
            AddProjet addProjet = new AddProjet();
            addProjet.Show();
        }

        private int _sliderValeur;

        public int SliderValeur
        {
            get { return _sliderValeur; }
            set
            {
                _sliderValeur = value;
                OnPropertyChanged(nameof(SliderValeur));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
