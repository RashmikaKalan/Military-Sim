using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA2
{
    public class Jets
    {
        private string jetID, name, topSpeed, fuelTankSize, inventoryCapacity, typeOfWeapons, maximumAltitude;

        public string JetID { get => jetID; set => jetID = value; }
        public string Name { get => name; set => name = value; }
        public string TopSpeed { get => topSpeed; set => topSpeed = value; }
        public string FuelTankSize { get => fuelTankSize; set => fuelTankSize = value; }
        public string InventoryCapacity { get => inventoryCapacity; set => inventoryCapacity = value; }
        public string TypeOfWeapons { get => typeOfWeapons; set => typeOfWeapons = value; }
        public string MaximumAltitude { get => maximumAltitude; set => maximumAltitude = value; }       

        public Jets()
        {

        }

        public Jets(string jc, string jn, string ts, string ft, string ic, string tw, string ma)
        {
            jetID = jc;
            name = jn;
            topSpeed = ts;
            fuelTankSize = ft;
            inventoryCapacity = ic;
            typeOfWeapons = tw;
            maximumAltitude = ma;
        }
    }
}
