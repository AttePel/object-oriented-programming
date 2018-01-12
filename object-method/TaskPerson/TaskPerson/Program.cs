using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Person personMatti = new Person();
			personMatti.Name = "Matti";
			Console.WriteLine($"Matin ikä: {personMatti.GetAge()}");

			personMatti.GrowOld();
			Console.WriteLine($"Matin ikä: {personMatti.GetAge()}");
			personMatti.GrowOld(50);
			personMatti.PrintPersonInfo();

			Person newPerson = new Person("Joe Doe", 18);
			newPerson.PrintPersonInfo();
			newPerson.GrowOld();
			newPerson.PrintPersonInfo();
			Console.ReadKey(); 
        }
    }
}
