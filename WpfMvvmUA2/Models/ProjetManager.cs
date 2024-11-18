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
            new Projet {Titre = "Developpement de l'application mobile de gestion", Avancement= 34},
            new Projet {Titre = "Creation d'un CRM interne", Avancement= 50},
            new Projet {Titre = "Deploiement du système ERP", Avancement= 70}

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
