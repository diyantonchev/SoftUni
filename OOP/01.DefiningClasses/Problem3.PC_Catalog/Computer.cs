using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Computer
{
    private string name;
    private List<Component> components;

    public Computer(string name)
    {
        this.Name = name;
    }

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components; 
    }

    public string Name
    {
        get { return this.Name = name;}
        set {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
                throw new ArgumentException("Incorrect name");
            this.name = value;
            }
    }

    public double Price 
    {
        get { return this.Components.Sum(component => component.Price); }
    }

    public List<Component> Components 
    {
        get { return this.components;}

        set
        {
            if (value.Count < 1)
                throw new ArgumentException("Computer components can not be zero!");
            this.components = value;
        }
    }

    public override string ToString()
    {
        var computerProperties = new StringBuilder();

        computerProperties.AppendLine(string.Format("Computer: {0}", this.name));

        computerProperties.AppendLine("Components:");
        foreach (var component in components)
        {
            computerProperties.Append(component);
        }

        computerProperties.AppendFormat("Total computer price {0:C}", this.Price);

        return computerProperties.ToString();
    }
}

