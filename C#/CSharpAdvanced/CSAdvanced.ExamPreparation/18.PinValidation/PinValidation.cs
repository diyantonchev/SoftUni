using System;

class PinValidation
{
    static void Main()
    {
        string firtstName;
        string lastName;

        var inputName = Console.ReadLine();
        try
        {
            string[] names = inputName.Split(' ');
            firtstName = names[0];
            lastName = names[1];
        }
        catch (Exception)
        {
            Console.WriteLine("<h2>Incorrect data</h2>");
            return;
        }

        string gender = Console.ReadLine();
        long pin = long.Parse(Console.ReadLine());


        var person = new Person();
        try
        {
            person = new Person(firtstName, lastName, gender, pin);
           
        }
        catch (Exception)
        {
            Console.WriteLine("<h2>Incorrect data</h2>");
            return;
        }

        Console.WriteLine(@"{0}""name"":""{1} {2}"",""gender"":""{3}"",""pin"":""{4}""{5}", "{"
            , person.FirstName, person.LastName, person.Gender, person.Pin, "}");
    }
}

public class Person
{
    private string firstName;

    private string lastName;

    private string gender;

    private long pin;

    public Person()
    {

    }

    public Person(string firstName, string lastName, string gender, long pin)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Pin = pin;
        this.Gender = gender;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException();
            }
            this.firstName = value;
        }

    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException();
            }
            this.lastName = value;
        }

    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            if (!this.GenderIsValid(value) == false)
            {
                throw new ArgumentException();
            }
            this.gender = value;
        }
    }

    public long Pin
    {
        get
        {
            return this.pin;
        }

        set
        {
            if (!this.PinIsValid(value) || value.ToString().Length != 10)
            {
                throw new ArgumentException();
            }
            this.pin = value;
        }
    }

    private bool PinIsValid(long value)
    {
        string p = value.ToString();

        int[] numbers = new int[9] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

        long sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += numbers[i] * p[i];
        }

        long checksum = sum / 11;

        if (checksum == 10)
        {
            checksum = 0;
        }

        return checksum == p[9];
    }

    private bool GenderIsValid(string value)
    {
        string pinAsString = this.Pin.ToString();
        char lastDigitChar = pinAsString[pinAsString.Length - 1];
        int lastDigit = int.Parse(lastDigitChar.ToString());

        bool isEven = lastDigit % 2 == 0;

        if (isEven && this.Gender == "male")
        {
            return true;
        }
        return !isEven && this.Gender == "female";
    }
}