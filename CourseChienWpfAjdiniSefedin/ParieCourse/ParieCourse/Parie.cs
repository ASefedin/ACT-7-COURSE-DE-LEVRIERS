using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ParieCourse
{
    internal class Parie
    {

		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
		private Parie _monPari;

		public Parie MonPari
		{
			get { return _monPari; }
			set { _monPari = value; }
		}

		private int _cash;

		public int Cash
		{
			get { return _cash; }
			set { _cash = value; }
		}

		private TextBlock _textBlockEtatPari;

		public TextBlock TextBlockEtatPari
        {
			get { return _textBlockEtatPari; }
			set { _textBlockEtatPari = value; }
		}

		public Parie(string nom, Parie monPari, int cash, TextBlock textBlockEtatPari)
		{
			_nom = nom;
			_monPari = monPari;
			_cash = cash;
			_textBlockEtatPari = textBlockEtatPari;
		}

        public string GetDescription(TextBlock txtInfos)
        {
            string info = "";
            return info;
        }

        public string PrixFinal(int numGagnant)
        {
            string info = "";
            return info;
        }
    }
}
