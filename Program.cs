// See https://aka.ms/new-console-template for more information
using static ConsoleApp9.test1;

Console.WriteLine("Hello, World!");


Test<string> test = new Test<string>();
test.Add("Salam1");
test.Add("Salam");
test.Add("Salam1");
test.Add("Salam");
test.customRemove ("Salam");
test.ShowAll();
