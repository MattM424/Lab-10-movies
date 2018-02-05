using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Movies
{
    class MovieObject
    {
        private string movietitle;
        private string Genere;
        private int catagoryNum;

        public string Movietitle
            {
                set { movietitle = value; }  // used to change value of the field

                get { return movietitle; }  // used to retur the value of the field

            }

        public string genere
        {
            set { Genere = value; }  // used to change value of the field

            get { return Genere; }  // used to retur the value of the field

        }

        public int CatagoryNum
        {
            set { catagoryNum = value; }  // used to change value of the field

            get { return catagoryNum; }  // used to retur the value of the field

        }

        public MovieObject(string movieTitle, string genere,int catagorynum)
        {
            movietitle = movieTitle;
            Genere = genere;
            catagoryNum = catagorynum;

        }
    }

    
}
