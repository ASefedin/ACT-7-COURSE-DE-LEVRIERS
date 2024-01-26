using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParieCourse
{
    internal class Parieur
    {
		protected int _montant;

		public int Montant
		{
			get { return _montant; }
			set { _montant = value; }
		}

		protected int _numChien;

		public int NumChien
		{
			get { return _numChien; }
			set { _numChien = value; }
		}

		protected Parieur _joueur;

		public Parieur Joueur
        {
			get { return _joueur; }
			set { _joueur = value; }
		}

		public Parieur(int montant, int numChien, Parieur joueur)
		{
			_montant = montant;
			_numChien = numChien;
			_joueur = joueur;
		}

        public string Parie(int valeurPari, int numChien)
        {
            string info = "";
            return info;
        }

        public string ResetPari()
        {
            string info = "";
            return info;
        }

        public string MajInfos()
        {
            string info = "";
            return info;
        }
    }
}
