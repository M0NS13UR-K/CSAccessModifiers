
namespace CSAccessModifiers
{
    public class Animal //Base class
    {
        public string Name { set; get;}
        private int age;
        protected string Species{ get; set;}
        internal string Habitat {get; set;}
        protected internal string FoodType {get; set;}
        public Animal(string name, int age, string species, string habitat, string foodtype)
        {
            Name = name;
            this.age = age;
            Species = species;
            Habitat = habitat;
            FoodType = foodtype;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Animal : {Name}, Species: {Species}, Habitat : {Habitat}, Age : {age}, FoodType : {FoodType}");
        }

        private void DisplayAge()
        {
            Console.WriteLine($"The age of the animal is {age}");
        }

        public void ShowAge()
        {
            DisplayAge();
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age, string habitat) : base(name, age, "Dog", habitat, "Carnivore")
        {}
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