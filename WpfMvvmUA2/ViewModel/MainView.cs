using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMvvmUA2.Commands;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Views.Controls;

namespace WpfMvvmUA2.ViewModel
{
    public class MainView
    {
        public ObservableCollection<Projet> Projets { get; set; }
        public ICommand ShowWindow { get; set; }
        public MainView()
        {
            Projets = ProjetManager.GetProjets();
            ShowWindow = new MyICommand(ExcuteShowWindow,CanExcuteShowWindow);
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

    }

}
