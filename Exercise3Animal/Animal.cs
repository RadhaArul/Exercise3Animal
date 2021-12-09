using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Animal
{
    //3.2.14F
    //[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)] with help if this code we can add
    // new Attribute to the Parent Class Animal
    public abstract class Animal //Abstract Class , :Attribute (for to create new attribute)
    {
        string Name;
        double Weight;
        int Age;
        public string name { get; set; }
        public double weight { get; set; }
        public int age { get; set; }

        public abstract void DoSound(); //Abstract Method
        public Animal()
        {
        }
        public virtual string Stats()
        {
            return ($"{name} {weight} {age} ");
        }
    }
    public class Horse : Animal // Class Animal inherit in the child class Horse
    {
        private string Gallop = "Gallop";
        public override void DoSound() // Abstract Method declared here with override keyword
        {
            Console.WriteLine("Horse Says : neigh");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {Gallop}");
        }
        public Horse(string name, double weight, int age, string gallop)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            Gallop = gallop;
        }
    }
    public class Dog : Animal
    {
        private string CoolPet = "CoolPet";
        public override void DoSound()
        {
            Console.WriteLine("Dog Says : bow-wow");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {CoolPet}");
        }
        public Dog(string name, double weight, int age, string Coolpet)
        {
            this.name = name;
            this.weight = weight;
            CoolPet = Coolpet;
        }
        public Dog() { }
        public string color() //15. Create a new method with any name in the Dog class that returns only an optional string.
        {
            return "Dogs are black, brown,grey and white in color";
        }
        //16. Do you access that method from the Animals list?
        //17. F: Why not?
        // i can access this method from the Animal list by using casting
    }
    public class Hedgehog :Animal
    {
        private string NrOfSpikes;
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog Says : growl");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {NrOfSpikes}");
        }
        public Hedgehog(string name, double weight, int age, string nrofspikes)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            NrOfSpikes = nrofspikes;
        }
    }
    class Worm : Animal
    {
        private string IsPoisonous;
        public override void DoSound()
        {
            Console.WriteLine("Worm Says : SSSSSS");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {IsPoisonous}");
        }
        public Worm(string name, double weight, int age,string ispoisonous)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            IsPoisonous = ispoisonous;
        }
    }
    //3.2.13F
    //[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)] with help if this code we can add
    // new Attribute to the Parent Class Bird
    class Bird : Animal //:Attribute
    {
        private string WingSpan;
        public override void DoSound()
        {
            Console.WriteLine("Bird Says : Chirp");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {WingSpan}");
        }
        public Bird(string name, double weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            
        }
    }
    class Wolf : Animal
    {
        private string KeenSenses;
        public override void DoSound()
        {
            Console.WriteLine("Wolf Says : Owooooo");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {KeenSenses}");
        }
        public Wolf(string name, double weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
           
        }
    }
    class Pelican : Bird // Parent Class Bird inherit in the child class Pelican
    {
        private string LargeBodyShortLeg;
        public override void DoSound()
        {

        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {LargeBodyShortLeg}");
        }
        public Pelican(string name, double weight, int age, string largebodyshortleg) :base( name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            LargeBodyShortLeg = largebodyshortleg;
        }
    }
    class Flamingo : Bird
    {
        private string VeryLargeNeck;
        public override void DoSound()
        {

        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {VeryLargeNeck}");
        }
        public Flamingo(string name, double weight, int age,string verylargeneck) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            VeryLargeNeck = verylargeneck;
        }
    }
    class Swan : Bird
    {
        private string WorldBeauty;
        public override void DoSound()
        {

        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} {WorldBeauty}");
        }
        public Swan(string name, double weight, int age,string worldbeauty) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            WorldBeauty = worldbeauty;
        }
    }
    class Wolfman : Wolf, Person //Class that inherits from Wolf and implements the IPerson interface.
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman says : Roar");
        }
        public override string Stats()
        {
            return ($"{name} {weight} {age} ");
        }
        public Wolfman(string name, double weight, int age) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age; ;
        }
    }
}
