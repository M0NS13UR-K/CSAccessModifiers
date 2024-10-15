using System;

namespace AccessModifiersExample
{
    // Base class (Parent)
    public class Animal
    {
        // public: Accessible from anywhere
        public string Name { get; set; }

        // private: Accessible only within this class
        private int age;

        // protected: Accessible within this class and derived classes
        protected string Species { get; set; }

        // internal: Accessible within this assembly (the current project)
        internal string Habitat { get; set; }

        // protected internal: Accessible within this assembly and by derived classes
        protected internal string FoodType { get; set; }

        public Animal(string name, int age, string species, string habitat, string foodType)
        {
            Name = name;
            this.age = age;
            Species = species;
            Habitat = habitat;
            FoodType = foodType;
        }

        // Public method: Accessible from anywhere
        public void DisplayInfo()
        {
            Console.WriteLine($"Animal: {Name}, Species: {Species}, Age: {age}, Habitat: {Habitat}, Food: {FoodType}");
        }

        // Private method: Only accessible within this class
        private void DisplayAge()
        {
            Console.WriteLine($"The animal is {age} years old.");
        }

        // Public method to call the private method within the class
        public void ShowAge()
        {
            DisplayAge(); // Can access the private method here
        }
    }

    // Derived class (Child)
    public class Dog : Animal
    {
        public Dog(string name, int age, string habitat)
            : base(name, age, "Dog", habitat, "Carnivore")
        {
        }

        public void DisplaySpeciesAndFood()
        {
            // Access protected and protected internal properties from the parent class
            Console.WriteLine($"This is a {Species} and it eats {FoodType}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal("Lion", 5, "Lion", "Savannah", "Meat");
            lion.DisplayInfo();     // Accessible, public method
            lion.ShowAge();         // Accessible, public method to call private method
            
            Dog dog = new Dog("Bulldog", 3, "House");
            dog.DisplayInfo();      // Inherited public method
            dog.DisplaySpeciesAndFood();  // Accessing protected members in a derived class

            // Try accessing internal member from another part of the same assembly
            Console.WriteLine($"The dog's habitat is {dog.Habitat}.");

            // The following lines would give errors if uncommented:
            // lion.age = 6;        // Error: 'age' is private
            // dog.Species = "Cat"; // Error: 'Species' is protected
        }
    }
}
