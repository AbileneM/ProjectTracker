using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Views;

namespace WpfMvvmUA2.ViewModel
{
    class ProjetsViewModel
    {
        public ObservableCollection<Projet> Projets { get; set; }
        public ICommand ShowWindow { get; set; }

        public ProjetsViewModel()
        {
            Projets = ProjetManager.GetProjets();
            ShowWindow = new MyICommand(ExcuteShowWindow, CanExcuteShowWindow);
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
