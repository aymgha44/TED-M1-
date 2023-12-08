using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class CompteEpargne:Compte
    {
        protected float taux;
        protected float vi;

        public CompteEpargne(float taux,float s) : base(s)
        {
        this.taux = taux;
        }

        public CompteEpargne(float taux) : base()
        {
            this.taux = taux;
        }

        public void calculerInterets() 
        {
            vi= solde * taux;
        }

        public void ajouterInterets()
        {
           calculerInterets();
            solde = solde + vi;
        }

        public override string ToString()
        {
            return base.ToString()+" Interet " +vi;
        }

    }
}
