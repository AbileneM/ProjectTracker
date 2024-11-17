using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmUA2.Models
{
    public class ProjetManager
    {
        public static ObservableCollection<Projet> _ListeProjet = new ObservableCollection<Projet>()
        { 
            
        };

        public static ObservableCollection<Projet> GetProjets()
        {
            return _ListeProjet;
        }
        public static void AjouterProjet(Projet projet)
        {
            _ListeProjet.Add(projet);
        }
    }
}
