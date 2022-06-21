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

        public int CheckTreasury(ElvenHouse feanor1)          
        {
            if (feanor1.Craft > 100)
            {
                NumberOfSilmaril+=1;
                return NumberOfSilmaril;
            }

            else
                return NumberOfSilmaril;
        }

    }
}