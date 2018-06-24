using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var Phonebook = GetPhonebookDictionary(command);
            
        }

        static Dictionary<string, string> GetPhonebookDictionary(string command)
        {
            var Phonebook = new Dictionary<string, string>();
            while (command != "END")
            {
                var input = command.Split(' ');
                var action = input[0];
                
                switch (action)
                {
                    case "A":
                        var name = input[1];
                        var phone = input[2];
                        Phonebook.Add(name, phone);
                        break;
                    case "S":
                        name = input[1];
                        if (!Phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("The contact {0} does not exist.", name);
                        }
                        else
                        {
                            Console.WriteLine("{0} -> {1}", name, Phonebook[name]);
                        }
                        break;
                    case "ListAll":
                        var orderedPhonebook = new SortedDictionary<string, string>();
                        foreach (var item in Phonebook)
                        {
                            orderedPhonebook.Add(item.Key, item.Value);
                        }
                        foreach (var item in orderedPhonebook)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                        }
                        break;
                  
                }

                command = Console.ReadLine();
            }

            return Phonebook;
        }
    }
}
