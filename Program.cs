using System;
using System.Collections.Generic;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        //syntax - diction<key data type, value data type> dictionaryName 
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 },         //Kerry is the key, 90 is the value ;populating the dictionary with key value pairs. name is not a good key value
                {"Barry", 85 },         //there could be more than one kerry
                {"Michelle", 100 }
            };



            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>(); //empty dictionary, like an empty list or an empty array
                                                                                  //that's wh we have a ;

            //using the add method, let's add drinks to our machine
            //this machine uses just a number to vend an item instead
            //of a letter/number pair.

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(2, "Diet Coke");
            drinkMachine.Add(3, "Cherry Coke");
            drinkMachine.Add(4, "Rootbeer");
            drinkMachine.Add(6, "Vernors");
            drinkMachine.Add(8, "Pepsi");

            Console.WriteLine(drinkMachine.Count); //count is a property, not a method. It returns the size of the dictionary
            //we have another property called .Key
            foreach (KeyValuePair<int, string> drink in drinkMachine)
                Console.WriteLine(drink.Key);

            foreach (KeyValuePair<int, string> drink in drinkMachine)  //can use drink again because it's local variable to the loop it's in
                Console.WriteLine(drink.Value);

            //create a dictionary for a theater coat check with 10 elements
            //the key will be a number, and the value will be the coat style
            //print all values to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1, "Red leather coat"},
                {2, "Jean Jacket" },
                {3, "Pea coat" },
                {4, "Down vest" },
                {5, "Down coat" },
                {6, "Rain coat" },
                {7, "Cape" },
                {8, "Black leather jacket" },
                {9, "Baseball jacket" },
                {10, "Hooded sweatshirt" }
            };

            foreach (KeyValuePair<int, string> coat in coatCheck)
                Console.WriteLine(coat.Key);

            foreach (KeyValuePair<int, string> coat in coatCheck)  //can use drink again because it's local variable to the loop it's in
                Console.WriteLine(coat.Value);


            //create a dictionary for a car valet service with 10 cars.
            //the key will be the customer's last name and the value
            //will be the car make. print all keys to the console.

            Dictionary<string, string> carValet = new Dictionary<string, string>();


            carValet.Add("Jones", "Chevy");
            carValet.Add("Smith", "Honda");
            carValet.Add("London", "Ford");
            carValet.Add("James", "Volkeswagon");
            carValet.Add("Redford", "Kia");
            carValet.Add("Patrick", "Subaru");
            carValet.Add("Seiger", "Porsch");
            carValet.Add("Apple", "Honda");
            carValet.Add("Paul", "Lexus");
            carValet.Add("Spangler", "Toyota");

            foreach (KeyValuePair<string, string> name in carValet)
                Console.WriteLine(name.Key);


            //Create a dictionary of 10 zoo animals
            //the key will be the animal type
            //the value will be the number of that
            //animal type at the zoo.
            //print the animal with the highest quanity to the console.


            Dictionary<string, int> zooAnimal = new Dictionary<string, int>();

            zooAnimal.Add("Monkey", 25);
            zooAnimal.Add("Lion", 2);
            zooAnimal.Add("Elephant", 3);
            zooAnimal.Add("Hippo", 2);
            zooAnimal.Add("Tiger", 5);
            zooAnimal.Add("Polar Bear", 6);
            zooAnimal.Add("Zebra", 4);
            zooAnimal.Add("Flamingo", 30);
            zooAnimal.Add("Giraffe", 3);
            zooAnimal.Add("Gorilla", 6);

            Console.WriteLine("Flamingo " + 30);
          //  need a way to sort by value and get highest value

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimal) 
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            Console.WriteLine(highest); //will print the number
            foreach (KeyValuePair<string, int> animal in zooAnimal)


            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }


            //we won't be using dictionaries very much



        }


    }
}
