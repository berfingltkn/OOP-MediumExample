using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Berfin", 22, "aaaa", "aaaa", "aaaa");

            string name=person.GetName();
            Console.WriteLine(name);
        }
    }
}
public class Person
{
    private string _name;
    private int _age;
    private string _personality;
    private string _beliefs;
    private string _mood;


    public Person(string name, int age, string personality, string beliefs, string mood)
    {
        _name = name;
        _age = age;
        _personality = personality;
        _beliefs = beliefs;
        _mood = mood;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge() 
    {
        return _age;
    }
    public void SharePersonality()
    {
        Console.WriteLine($"My personality is: {_personality}");
    }
    public void ShareBeliefs()
    {
        Console.WriteLine($"My beliefs are: {_beliefs}");
    }
    public void UpdateMood(string newMood)
    {
        _mood = newMood;
    }

    public void ExpressMood()
    {
        Console.WriteLine($"My current mood is: {_mood}");
    }
}

