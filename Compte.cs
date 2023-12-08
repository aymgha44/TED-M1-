using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Compte
    {
        protected int code;
        protected float solde;
        private static int nbComptes;
        public Compte(float s)
        {
            this.code = ++nbComptes;
            this.solde = s;
        }
        public Compte()
        {
            this.code = ++nbComptes;
                   }
        public void Verser(float mt)
        {
            solde += mt;
        }
        public void Retirer(float mt)
        {
            solde -= mt;
        }
        public override string ToString()
        {
            return "code = " + code + " solde = " + solde;
        }
        public static int GetNbComptes()
        {
            return nbComptes;
        }
    }
}