using System;
   
class DefiningClasses_ExerciseMain
    {
        static void Main()
        {
            Dog sharo = new Dog("Sharo", "Melez");

            Dog unnamed = new Dog();
            unnamed.Breed = "Street Delicious";

            unnamed.Bark();
            sharo.Bark();
        }
    }
