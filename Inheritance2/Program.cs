using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Female female = new Female("X", 27);
            Male male = new Male("Y", 25);
            
            female.GetGender();
            male.GetGender();

           
        }
    }

   
}

public class Human
{
    public string name;
    public int age;


    public Human(string name,int age)
    {
        this.name = name;
        this.age = age;

    }
    public void Information()
    {
        Console.WriteLine($"My name is {name} and i am {age} years old.");

    }
}

public class Female:Human
{
    public Female(string name,int age):base(name,age)
    {

    }
    public  void GetGender()
    {
        Console.WriteLine($"My name is {name} and i am {age} years old female.");
    }

}

public class Male:Human
{
    public Male(string name, int age) : base(name, age)
    {

    }
    public void GetGender()
    {
        Console.WriteLine($"My name is {name} and i am {age} years old male.");
    }
}

