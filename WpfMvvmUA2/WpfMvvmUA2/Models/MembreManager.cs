using System;
using System.Collections.ObjectModel;

namespace WpfMvvmUA2.Models
{ 

  public class MembreManager
  {
    public static ObservableCollection<Membre> MembreList = new ObservableCollection<Membre>
    {
      new Membre { Nom = "Durand", Prenom = "Elodie" , Role = "Testeur",  Email = "elodie.durand@example.com"},
      new Membre { Nom = "Leblanc", Prenom = "Lucas", Role = "Testeur",  Email = "lucas.leblanc@example.com" },
      new Membre { Nom = "Roche", Prenom = "Manon",  Role = "Testeur", Email = "manon.roche@example.com" },
      new Membre { Nom = "Morel", Prenom = "Alexandre", Role = "Testeur",  Email = "alexandre.morel@example.com" },
      new Membre { Nom = "Dumont", Prenom = "Isabelle", Role = "Testeur",  Email = "isabelle.dumont@example.com" },
      new Membre { Nom = "Faure", Prenom = "Pauline", Role = "Testeur",  Email = "pauline.faure@example.com"},
      new Membre { Nom = "Marchand", Prenom = "Julien", Role = "Testeur",  Email = "julien.marchand@example.com",},
      new Membre { Nom = "Caron", Prenom = "Chloe", Role = "Testeur",  Email = "chloe.caron@example.com", },
      new Membre { Nom = "Garnier", Prenom = "Mathieu", Role = "Testeur",  Email = "mathieu.garnier@example.com" },
      new Membre { Nom = "Perrin", Prenom = "Camille", Role = "Testeur",  Email = "camille.perrin@example.com"}
    };
    public static ObservableCollection<Membre> GetMembres()
    {
        return MembreList;
    }
    public static void AddMembre(Membre membre)
    {
        MembreList.Add(membre);
    }
  }
}
