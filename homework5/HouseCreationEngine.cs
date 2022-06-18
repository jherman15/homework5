using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class HouseCreationEngine
    {
        public static ElvenHouse CreateNoldor()
        {
            ElvenHouse noldorHouse = new Noldor();
            //HouseCreationEngine.choosing(noldorHouse);
            return noldorHouse;
        }

        public static ElvenHouse CreateTeleri()
        {
            ElvenHouse teleriHouse = new Teleri();
            return teleriHouse;
        }

        public static ElvenHouse CreateVanyar()
        {
            ElvenHouse vanyarHouse = new Vanyar();
            return vanyarHouse;
        }
    }
}
