using System;
using System.Collections.Generic;
using System.Text;

namespace homework5
{
    internal class Treasury
    {
        private Noldor feanor;
        public int NumberOfSilmaril = 0;

        public Treasury(Noldor feanor)
        {
            Feanor = feanor;
        }

        public Noldor Feanor
        {
            get { return feanor; }
            set { feanor = value; }
        }

        public int CheckTreasury()          //jakiś argument?
        {
            if (Feanor.Craft > 100)
                return NumberOfSilmaril += 1;
            else
                return NumberOfSilmaril;
        }

        //metoda get liczba bułek, jeśli chcę zaglądnąć
        //jeśli to ma fabularne uzasadnienie, to ok
        //nie mozna podlądnać wartości nie wchodząc w nią

    }
}