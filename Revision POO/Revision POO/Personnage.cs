using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_POO
{
    internal class Personnage: ElementDeJeu
    {
        int charisma, constitution, dexterity, intelligence, strenght, wisdom;
        Random rand = new Random();
        public int Experience { get; set; }
        public string Nom { get; set; }
        public int Poid { get; set; }
        public string Sexe { get; set; }
        public int Taille { get; set; }

        public override void AfficheCoucou()
        {
            base.AfficheCoucou();
        }
        public virtual void AfficheStat()
        {

        }
        public override void AfficheToto()
        {
            base.AfficheToto();
        }
        
    }
}
