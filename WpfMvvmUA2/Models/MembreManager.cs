using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmUA2.Models
{
    public class MembreManager
    {
        public static ObservableCollection<Membre> _ListeMembre = new ObservableCollection<Membre>()
        {
            new Membre { Nom = "Durand", Prenom = "Elodie", Email = "elodie.durand@example.com", Role = "Manager" },
            new Membre { Nom = "Leblanc", Prenom = "Lucas", Email = "lucas.leblanc@example.com",  Role = "Manager"  },
            new Membre { Nom = "Roche", Prenom = "Manon", Email = "manon.roche@example.com",  Role = "Manager"  },
            new Membre { Nom = "Morel", Prenom = "Alexandre", Email = "alexandre.morel@example.com",  Role = "Manager"  },
            new Membre { Nom = "Dumont", Prenom = "Isabelle", Email = "isabelle.dumont@example.com", Role = "Manager"  },
            new Membre { Nom = "Faure", Prenom = "Pauline", Email = "pauline.faure@example.com",  Role = "Manager"  },
            new Membre { Nom = "Marchand", Prenom = "Julien", Email = "julien.marchand@example.com",  Role = "Manager"  },
            new Membre { Nom = "Caron", Prenom = "Chloe", Email = "chloe.caron@example.com",  Role = "Manager"  },
            new Membre { Nom = "Garnier", Prenom = "Mathieu", Email = "mathieu.garnier@example.com",  Role = "Manager" },
            new Membre { Nom = "Perrin", Prenom = "Camille", Email = "camille.perrin@example.com", Role = "Manager" }
        };

        public static ObservableCollection<Membre> GetMembres()
        {
            return _ListeMembre;
        }
        public static void AjouterMembre(Membre membre)
        {
            _ListeMembre.Add(membre);
        }
    }
}
