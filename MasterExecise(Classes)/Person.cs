using System;

namespace MasterExecise_Classes_;

public class Person
{
  private string _name;
  private int _age;

  public string Name { get; set; }
  public int Age
  {
    get
    {
      return _age;
    }
    set
    {
      if (value > 0)
      {
        _age = value;
      }
      else
      {
        Console.WriteLine("Age should be greater than 0");
      }
    }
  }
  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }
  public void Greet()
  {
    Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
  }
}
