using System;

class Test
{
    static void Main()
    {
        Student student = new Student("Marcho Marchev", 23);

        student.PropertyChange += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
        eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);

            };

        student.Name = "Goshko";
        student.Age = 8;
    }
}