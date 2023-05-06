using System;
using System.Collections.Generic;
using System.Text;

namespace Practicing
{
    public class Interface
    {
        static void Main(string[] args)
        {
            AnimalProperty animalProperty=new AnimalProperty();
            Lion lion = new Lion(animalProperty);
            lion.AnimalAllName("Gaffur", "Prenses Lion");
        }
        public interface IAnimal
        {
            public string AnimalAllName(string manName, string famaleName);
        }

        public class AnimalProperty
        {
            public int AnimalCount { get; set; }
            public string Name { get; set; }
            public string Habibat { get; set; }
            public int FamaleCount { get; set; }
            public int ManCount { get; set; }
        }

        public class Lion : IAnimal
        {
            AnimalProperty _animalProperty1;
            public Lion(AnimalProperty animalProperty1)
            {
                _animalProperty1 = animalProperty1;
            }
            public string AnimalAllName(string manName, string famaleName)
            {
                _animalProperty1.Name = "Aslan";
                _animalProperty1.AnimalCount = 2;
                _animalProperty1.FamaleCount = 1;
                _animalProperty1.ManCount = 1;
                _animalProperty1.Habibat = "Orman";
                Console.WriteLine(_animalProperty1.Name + _animalProperty1.ManCount);
                Console.WriteLine($"Erkek hayvan ismi:{manName}\nDişi hayvan ismi:{famaleName}");
                return null;
            }

            public int AnimalCountSum(int manCount, int FamelaCount)
            {
                return manCount + FamelaCount;
            }
        }
    }
}
