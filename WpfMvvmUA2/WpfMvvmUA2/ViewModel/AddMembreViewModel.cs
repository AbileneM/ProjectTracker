using System.Windows.Input;
using WpfMvvmUA2.Models;

namespace WpfMvvmUA2.ViewModel
{
    public class AddMembreViewModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public ICommand AddMembreCommand { get; set; }

        // Action pour fermer la fenêtre
        public Action CloseAction { get; set; }

        public AddMembreViewModel()
        {
            AddMembreCommand = new MyICommand(ExecuteAddMembre, CanExecuteAddMembre);
        }

        private bool CanExecuteAddMembre(object obj)
        {
            return true;
        }

        private void ExecuteAddMembre(object obj)
        {
            MembreManager.AddMembre(new Membre() { Nom = Nom, Prenom = Prenom, Role = Role, Email = Email });

            // Appelle l'action pour fermer la fenêtre
            CloseAction?.Invoke();
        }
    }

}
