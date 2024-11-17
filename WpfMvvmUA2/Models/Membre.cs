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
        
    }
}
