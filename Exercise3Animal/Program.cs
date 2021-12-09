using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise3Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal hr, wm;
            hr = new Horse("HorseA",30,12,"very strong animal");
            wm = new Wolfman("wolfmanA",120,8);
            animals.Add(hr);
            animals.Add(wm);

            foreach (var a in animals)
            {
                if (a.GetType().Name == "Wolfman")
                {
                    Console.WriteLine(a.Stats());
                    Person per = (Person)a;
                    per.Talk();
                }
                else
                {
                    Console.WriteLine(a.Stats());
                    a.DoSound();
                }
            }
            Console.WriteLine();

            List<Dog> dogs = new List<Dog>(); // create a list for dogs
                                              // dogs.Add(hr); // 9. F: Try adding a horse to the list of dogs. Why does it not work?
                                              // because they both have same parent Animal but there is no relationship between dog and horse.
                                              //10. F: What type must the list be in order for all classes to be stored together?
                                              // Type should be Animal in order to store all classes.

            // create all animals
            List<Animal> Allanimals = new List<Animal>();
            Animal Hrs, Dg,Dg1, Hd, Wo, Pe, Fl, Sw;
            Hrs = new Horse("Horse1",30,18,"Gallop"); 
            Dg = new Dog("Dog1",25,9,"Coolpet");
            Dg1 = new Dog("Dog2", 20, 8, "Coolpet");
            Hd = new Hedgehog("Hedgehog1",.1,1,"Has lot of spikes");
            Wo = new Worm("Worm1",.1,1,"This is poisonous");
            Pe = new Pelican("Pelican1",5,2,"it has very large body and short legs");
            Fl = new Flamingo("Flamingo1",7,3,"it has very large neck"); 
            Sw = new Swan("Swan1",3,2,"its worlds beauty");
            Allanimals.Add(Hrs); Allanimals.Add(Dg); Allanimals.Add(Hd); Allanimals.Add(Wo); 
            Allanimals.Add(Pe); Allanimals.Add(Fl); Allanimals.Add(Sw);Allanimals.Add(Dg1);

            //11. Print all Animals Stats () through a foreach loop.
            foreach (var A in Allanimals)
                Console.WriteLine(A.Stats());

            //13. F: Explain what is happening.
            // because of the keyword override it calles only corresponding devrived class Stats() method

            //14. Print the Stats () method for all dogs only through a foreach on Animals.
            Console.WriteLine();
            
            foreach ( var A in Allanimals)
            {
                if (A.GetType().Name == "Dog")
                {
                    Console.WriteLine(A.Stats());
                    Dog dd = (Dog)A;
                    string col = dd.color();
                    Console.WriteLine(col);
                    
                }
                    
            }
        }
    }
}