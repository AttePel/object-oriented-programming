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
			personMatti.GrowOld();
			personMatti.PrintPersonInfo();

			Person newPerson = new Person("Joe Doe", 18);
			newPerson.PrintPersonInfo();
			newPerson.GrowOld();
			newPerson.PrintPersonInfo();
			Console.ReadKey(); 
        }
    }
}
