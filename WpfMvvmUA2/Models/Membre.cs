using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmUA2.Models
{
    public class Membre
    { 
        public Membre() { } required 
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }

    public class MembreList
    {
        public static ObservableCollection<Membre> _ListeMembre = new ObservableCollection<Membre>()
        { };

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
