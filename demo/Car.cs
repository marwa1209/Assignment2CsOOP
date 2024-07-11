using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Car
    {
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        public Car(int id, string model)
        {
            Id = id;
            Model = model;
        }
        public Car(int id)
        {
            Id = id;
        }
        public Car()
        {
        }
        #region properties
        public int Id { get; set; }
        public string Model { get; set; }

        public double Speed { get; set; }
        #endregion
        public override string ToString()
        {
             return $"Id = {Id}\nModel={Model}\nSpeed = {Speed}";

        }
    }
}
