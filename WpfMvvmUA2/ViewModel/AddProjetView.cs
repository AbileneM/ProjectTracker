using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMvvmUA2.Commands;
using WpfMvvmUA2.Models;

namespace WpfMvvmUA2.ViewModel
{
    public class AddProjetView
    {
        public string Titre { get; set; }
        public int Avancement { get; set; }
        public ICommand AddProjetCommand { get; set; }

        // Action pour fermer la fenêtre
        public Action CloseAction { get; set; }

        public AddProjetView()
        {
            AddProjetCommand = new MyICommand(ExcuteAddProjet, CanExcuteAddProjet);
        }
        private bool CanExcuteAddProjet(object obj)
        {
            return true;
        }
        private void ExcuteAddProjet(object obj)
        {
            ProjetManager.AjouterProjet(new Projet()
            { Titre= Titre, Avancement = Avancement});

            // Appelle l'action pour fermer la fenêtre
            CloseAction?.Invoke();
        }
    }
}
