using System;
using System.Linq;

class AnimalsTest
{
    static void Main()
    {
        var tom = new Tomcat("Tommas", 3, "m");
        var bruno = new Tomcat("Bruno", 1, "male");
        var spike = new Dog("Spike", 4, "m");
        var dog = new Dog("Бенджи", 4, "male");
        var frog =  new Frog("Veso", 1, "female");
        var anotherFrog = new Frog("Sasho", 2, "m");
        var kitten = new Kitten("Kote", 2, "female");
        var cat = new Cat("Маца", 5, "f");
        var anotherKitty = new Kitten("Penka", 4, "female");
     
        Animal[] animals = new Animal[]
       {
           tom, dog, frog, kitten, cat, spike, bruno, anotherFrog, anotherKitty
       };

        foreach (var kind in animals.GroupBy(animal => animal.GetType()))
        {
            double averageAge = kind.Average(animal => (double)animal.Age);
            Console.WriteLine("{0} - average age: {1}", kind.Key, averageAge);
        }
    }
}
