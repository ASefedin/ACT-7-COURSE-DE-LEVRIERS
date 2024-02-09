using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ParieCourse
{
    internal class Chien
    {
		protected int _longueurPiste;

		public int LongueurPiste
        {
			get { return _longueurPiste; }
			set { _longueurPiste = value; }
		}

        protected int _numChien;

		public int NumChien
		{
			get { return _numChien; }
			set { _numChien = value; }
		}

        protected Image _imageChien;

		public Image ImageChien
		{
			get { return _imageChien; }
			set { _imageChien = value; }
		}

        protected int[] _positionCourante;

		public int[] PositionCourante
        {
			get { return _positionCourante; }
			set { _positionCourante = value; }
		}

        protected bool _gagne;

		public bool Gagne
		{
			get { return _gagne; }
			set { _gagne = value; }
		}

		public Chien(int longueurPiste, int numChien, Image imageChien, int[] positionCourante, bool gagne)
		{
			_longueurPiste = longueurPiste;
			_numChien = numChien;
			_imageChien = imageChien;
			_positionCourante = positionCourante;
			_gagne = gagne;
		}

		public string Court()
		{
			string info = "";
			return info;
		}
	}
}
