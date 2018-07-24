using System;
using static System.Console;
using System.Collections.Generic;

namespace ch3
{
    class Program
    {
        static void DemoIf() {
            int testGrade = 95;

            // Ex: if
            if (testGrade>85)
            {
               WriteLine("You did good!"); 
            }else{
                WriteLine("You did not work hard!");
            }

            // Ex: else if
            if (testGrade > 94)
            {
                WriteLine("You did awesome!");
            }
            else if (testGrade > 85)
            {
                WriteLine("You did good!");
            }
            else
            {
                WriteLine("You did not work hard!");
            }
            // Ex: multiple operators
            if ((testGrade >= 90) && (testGrade <= 95))
            {
                WriteLine("You almost reached excellence!");
            }
        }

        static void DemoLists() {
            // Create, print entire list of friends & first first friend
            WriteLine("Create, print entire list & just first friend:");
            WriteLine("---------------------------------------------");
            List<string> friend_list = new List<string> { "Sky", "Marcel",
                                                "Robin", "Khaleel", "Connie" };
            WriteLine($"All friends = '{friend_list[0]}','{friend_list[1]}'," +
                                    $"'{friend_list[2]}','{friend_list[3]}'," +
                                    $"'{friend_list[4]}'");

            WriteLine($"First Friend = '{friend_list[0]}'");

            // Change value
            friend_list[0] = "Taylor";
            WriteLine($"First Friend with name change = {friend_list[0]}");

            //Print partial list
            WriteLine($"Partial list of friends = '{friend_list[2]}','{friend_list[3]}','{friend_list[4]}'");

            // List within lists aka mulitdimensional array
            List<string> family_list = new List<string> { "Mom", "Dad", "Cousin" };
            List<List<string>> people_list = new List<List<string>>();
            people_list.Add(friend_list);
            people_list.Add(family_list);

            WriteLine("\nWrite out people_list:");
            WriteLine("-------------------------");
            people_list[0].ForEach(WriteLine);
            people_list[1].ForEach(WriteLine);
            WriteLine("\nWrite 3rd element from 2nd list:");
            WriteLine("-----------------------------------");
            WriteLine($"Third person in 2nd list is: {people_list[1][2]}");
        }

        static void DemoForLoops() {
            //Print from 0 to 4
            WriteLine("\n*Print from 0 to 4");
            for (int i = 0; i <= 4; i++)
            {
                Write($"{i} "); 
            }
            WriteLine();

            //Print list using 'foreach'
            WriteLine("\n*Print list using 'for'");
            List<string> friend_list = new List<string> { "Sky", "Marcel",
                                        "Robin", "Khaleel", "Connie" };
            foreach (string name in friend_list)
                WriteLine(name);

            //List within list aka 2-dimensional array
            WriteLine("\nPrinting nested loop");
            string[,] arrayOfPeople = new string[,] { { "Robin", "Khaleel", "Connie" },
                                                    {"Mom","Dad","Sister"} };
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    WriteLine(arrayOfPeople[x, y]);
                }
            }

            // Continue, Break
            string[] myItems = new string[] { "answer", "amazon", "banana", "badger", "clementine", "camel" };
            WriteLine("\n*Ex: 'continue' from list: " + string.Join(", ", myItems));
            foreach (var item in myItems)
            {
                if (item.StartsWith("b"))
                    continue;
                WriteLine(item);
            }

            WriteLine("\n*Ex: 'break' from list: " + string.Join(", ", myItems));
            foreach (var item in myItems)
            {
                if (item.StartsWith("b"))
                    break;
                WriteLine(item);

            }
        }

        static void DemoWhileLoops(){
            WriteLine("\n*While loop demo");
            int x = 0;
            while (x < 5)
            {
                WriteLine("Today, I've got time, son!");
                x = x + 1;
            }
        }

        static void DemoDictionary(){
            IDictionary<string, string> favorite_movie =
                new Dictionary<string, string>(){
                    {"Reynald","Titanic"},
                    {"Marcel", "Enter the Dragon"},
                    {"Khaleel","The Notebook"},
                    {"Connie","Superman"},
                };
          WriteLine("No shame, Reynald's fav movie is " + favorite_movie["Reynald"]); 

            // print entire dictionary
            foreach (KeyValuePair<string, string> item in favorite_movie)
            {
                WriteLine($"'{item.Key}': '{item.Value}'");
            }

            // delete value
            favorite_movie.Remove("Connie");

            // replace value
            favorite_movie["Khaleel"] = "Star Wars";

            WriteLine("\nReprinting dictionary after modifications");
            foreach (KeyValuePair<string, string> item in favorite_movie)
            {
                WriteLine($"'{item.Key}': '{item.Value}'");
            }



 
        }
        static void Main(string[] args)
        {
          //DemoIf();
          //DemoLists();
          //DemoForLoops();
          //DemoWhileLoops();
          DemoDictionary();
        }
    }
}
