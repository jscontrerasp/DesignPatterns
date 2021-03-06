using DesignPatterns.Creational_Patterns;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region AbstractFactory Example
            //Animal animal = null;
            //AnimalFactory animalFactory = null;
            //string speakSound = null;
            //// Create the Sea Factory object by passing the factory type as Sea
            //animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            //Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();
            //// Get Octopus Animal object by passing the animal type as Octopus
            //animal = animalFactory.GetAnimal("Octopus");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine("--------------------------");
            ////Create Land Factory object by passing the factory type as Land
            //animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            //Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();
            //// Get Lion Animal object by passing the animal type as Lion
            //animal = animalFactory.GetAnimal("Lion");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine();
            //// Get Cat Animal object by passing the animal type as Cat
            //animal = animalFactory.GetAnimal("Cat");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //#endregion

            //#region Factory
            //CreditCard creditCard = new PlatinumFactory().CreateProduct();
            //if (creditCard != null)
            //{
            //    Console.WriteLine("Card Type : " + creditCard.GetCardType());
            //    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            //    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.WriteLine("--------------");
            ////creditCard = new MoneyBackFactory().MakeProduct(); //return error, 'cause violate the method's protection level
            //creditCard = new MoneyBackFactory().CreateProduct();
            //if (creditCard != null)
            //{
            //    Console.WriteLine("Card Type : " + creditCard.GetCardType());
            //    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            //    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            //}
            //#endregion

            //#region Builder
            //Beverage beverage;
            //BeverageDirector beverageDirector = new BeverageDirector();

            //TeaBuilder tea = new TeaBuilder();
            //beverage = beverageDirector.MakeBeverage(tea);
            //Console.WriteLine(tea.GetBeverage());
            //Console.WriteLine(beverage.ShowBeverage());

            //CoffeeBuilder coffee = new CoffeeBuilder();
            //beverage = beverageDirector.MakeBeverage(coffee);
            //Console.WriteLine(beverage.ShowBeverage());
            //#endregion

            #region Builder Interface
            Director director = new Director();
            CarBuilder carBuilder = new CarBuilder();

            director.CreateSportCar(carBuilder);
            Car sportCar = carBuilder.getProduct();
            sportCar.infoCar();

            director.CreateReanultCar(carBuilder);
            Car reanultCar = carBuilder.getProduct();
            reanultCar.infoCar();
            
            #endregion

            #region 
            #endregion

            #region 
            #endregion

            #region 
            #endregion


            Console.Read();
        }
    }
}
