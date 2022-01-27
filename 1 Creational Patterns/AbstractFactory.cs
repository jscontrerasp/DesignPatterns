/*
 Provides an interface for creating families of related dependent objects without specifying their concrete classes.
 The Abstract Factory Pattern provides a way to encapsulate a group of individual factories that have a common theme 
    without specifying their concrete classes.
 The abstract factory design pattern is merely an extension to the factory method pattern or factory pattern, which 
    allows you to create objects without being concerned about the actual class of the object being created.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    public interface Animal {
        string speak();
    }

    #region create specific animals
    public class Cat : Animal {
        public string speak() => "Meow Meow Meow";
    }

    public class Lion : Animal {
        public string speak() => "Roar";
    }

    public class Octopus : Animal {
        public string speak() => "SQUAWCK";
    }

    public class Shark : Animal {
        public string speak() => "Cannot Speak";
    }
    #endregion

    #region Create abstract Factory
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }
    #endregion
    #region Create specific factories
    public class SeaAnimalFactory : AnimalFactory {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
                return new Shark();
            else if (AnimalType.Equals("Octopus"))
                return new Octopus();
            else
                return null;
        }
    }

    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Cat"))
                return new Shark();
            else if (AnimalType.Equals("Lion"))
                return new Octopus();
            else
                return null;
        }
    }
    #endregion


    class AbstractFactory {
    }
}
