using System;
using lib;
using System.Collections;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace MainProgram {
    class Program {
        static void Main(string[] args) {
             /* Entity Framework */

            var db = new DevContext(); // Création du Contexte


            //______________________________________________________________________
            /*
            db.Dev.Add(new Dev() {
                Name = "Aubert Alexis",
                Age = 18,
                Rating = 1.0f,
                Description = "",
                Price = 1000.0f,
                Pokename = "fff"
            }); // Insertion dans la base de données

            db.SaveChanges();
            */

            //______________________________________________________________________

            /* Recherche */
            /*var result = db.Dev.Where(x => x.Name.Contains("T"));

            foreach (var d in result) {
                Console.WriteLine(d.Name);
            }*/

//______________________________________________________________________

            bool again = true;

            System.Console.WriteLine("");

            foreach (var devs in db.Dev)
            {
                Console.WriteLine($"{devs.Id} : {devs.Name}");
            }

            while (again)
            {
                System.Console.WriteLine("");
                Console.Write("Enter the id of your dev : ");
                int val = Convert.ToInt32(Console.ReadLine());

                if (val >= 1 && val <=17)
                {
                    var results = db.Dev.Where(x => x.Id == val);
                    System.Console.WriteLine("                        ");
                    Console.WriteLine($"Name : {results.Single().Name}");
                    Console.WriteLine($"Pokéname : {results.Single().Pokename}");
                    Console.WriteLine($"Age : {results.Single().Age}ans");
                    Console.WriteLine($"Rating : {results.Single().Rating}/5");
                    Console.WriteLine($"Description : {results.Single().Description}");
                    Console.WriteLine($"Price : {results.Single().Price}€");
                    
                    bool isValid = false;
                    while(!isValid){  
                    System.Console.WriteLine("");
                    Console.WriteLine("Do you want to choose another dev ? (y / n)");
                    string key = Console.ReadLine();

                    if (key.Contains("y")|| key.Contains("Y")){
                        isValid = true;
                        again = true;
                    }
                    else if (  key.Contains("n") || key.Contains("N")){
                        isValid = true;
                        again = false;
                    }else{
                        Console.WriteLine("please enter a good value !"); }
                    }
                }
                    else { 
                        Console.WriteLine("choose a good id please !!!");
                        
                    }
                
            }

//______________________________________________________________________
            /* Affichage de tous les devs */
            /*foreach (var devs in db.Dev) {
                
                Console.WriteLine($"{devs.Name} : ");
                Console.WriteLine($"\t{devs.Age}");
                Console.WriteLine($"\t{devs.Description}");
                Console.WriteLine($"\tRate : {devs.Rating} / 5");
                Console.WriteLine($"\tPokemon : {devs.Pokename}");
                Console.WriteLine($"\tPrice : {devs.Price}");
            }*/


        }
    }
}