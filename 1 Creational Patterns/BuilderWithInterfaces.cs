using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    #region Car Class
    public class Car
    {
        public int Seats { get; set; }
        public string Engine { get; set; }
        public bool GPS { get; set; }
        public void infoCar() => Console.WriteLine("The car has " + this.Seats + " seats, the engine is " + this.Engine + " and has GPS? " + this.GPS);
    }
    #endregion

    #region Interface Builder
    public interface Builder
    {
        public abstract void Reset();
        public abstract void SetSeats(int seatsQuantity);
        public abstract void SetEngine(string engineType);
        public abstract void SetGPS(bool hasGPS);
    }
    #endregion

    #region Car Builder
    public class CarBuilder : Builder
    {
        private Car car;
        public CarBuilder() => this.Reset();
        public void Reset() => this.car = new Car();
        public void SetEngine(string engineType) => this.car.Engine = engineType;
        public void SetGPS(bool hasGPS) => this.car.GPS = hasGPS;
        public void SetSeats(int seatsQuantity) => this.car.Seats = seatsQuantity;
        public Car getProduct()
        {
            Car product = this.car;
            this.Reset();
            return product;
        }

    }
    #endregion

    #region Director
    public class Director
    {
        private Builder builder;

        public Builder setBuilder(Builder builder) => this.builder = builder;

        public void CreateSportCar(Builder builder)
        {
            builder.Reset();
            builder.SetEngine("automatic");
            builder.SetGPS(true);
            builder.SetSeats(2);
        }

        public void CreateReanultCar(Builder builder)
        {
            builder.Reset();
            builder.SetEngine("manual");
            builder.SetGPS(false);
            builder.SetSeats(4);
        }
    }
    #endregion

}
