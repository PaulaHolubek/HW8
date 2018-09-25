using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;


namespace FleetSim.Objects
{
    public class Car : Vehicle , ICar
    {
        private int _year;
        private string _make;
        private string _model;

        public Car() { }
 
        public Car(int year, string make, string model)
        {
            this._year = year;
            this._make = make;
            this._model = model;
        }

        public Car(int year, string make, string model,  ColorOptions NewColor)
        {
            this._year = year;
            this._make = make;
            this._model = model;
            this.carColor = NewColor;
        }

        public string model { get; set; }

        public int year { get; set; }

        public string make { get; set; }
    }
}
