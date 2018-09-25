using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;



namespace FleetSim.Objects
{
    public class Vehicle : IVehicle
    {
        private Guid _vin;
        private int _mileage;
        private DateTime _lastServicedDate;
        private int _lastServicedMileage;

        public Vehicle()
        {
        }

        public Vehicle(int vin, int mileage, DateTime lastServicedDate, int lastServicedMileage, ColorOptions NewColor)
        {
            carColor = ColorOptions.white;
        }

        public ColorOptions carColor { get; set; }

        public Guid vin
        {
            get { return _vin; }
            set { _vin = value; }
        }
 
        public int mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public DateTime lastServicedDate
        {
            get { return _lastServicedDate; }
            set { _lastServicedDate = value; }
        }

        public int lastServicedMileage
        {
            get { return _lastServicedMileage; }
            set { _lastServicedMileage = value; }
        }

       public void TuneUp(int mileage, int lastServicedMileage, DateTime lastServicedDate, string modelName)
        {
            if (mileage - lastServicedMileage >= 30000)
            {
                this._lastServicedMileage = mileage;
                this._lastServicedDate = DateTime.Now;
                System.Console.WriteLine($"Vehicle tuned up at {_lastServicedMileage} miles on {_lastServicedDate}");
            }
            if (mileage >= 100000)
            {
                RebuildEngine(modelName);
            }
        }

        public void RebuildEngine(string modelName)
        {
            mileage = 0;
            lastServicedMileage = 0;
            System.Console.WriteLine($"Engine rebuilt on {_lastServicedDate} for {modelName}");
            System.Console.ReadLine();
        }

    }
}

