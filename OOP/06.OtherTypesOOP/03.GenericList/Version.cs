using System;

[AttributeUsage(
       AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum
       | AttributeTargets.Method, AllowMultiple = false)]
public class Version : System.Attribute
{
    private int major;

    private int minor;

    public Version(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public int Major
    {
        get
        {
            return this.major;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "Value cannot be negative.");
            }
            this.major = value;
        }
    }

    public int Minor
    {
        get
        {
            return this.minor;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "Value cannot be negative.");
            }
            this.minor = value;
        }
    }
}