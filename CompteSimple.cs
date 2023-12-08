using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class CompteSimple : Compte
    {
        private float decouvert;

        public CompteSimple(float s, float dec) : base(s)
        {
            this.decouvert = dec;
        }

        public CompteSimple(float dec) : base()
        {
            this.decouvert = dec;
        }

        public override string ToString()
        {
            return base.ToString()+ " decouvert" +decouvert;
        }

        public new void Retirer(float mt)
        {
            if (mt - decouvert <= solde) ;
            solde -= mt;
        }
    }
}
