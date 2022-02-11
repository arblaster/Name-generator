
using System;
public class program
{
    static void Main(string[] args)
    {
        nameGen obj = new nameGen();
        obj.read();
        Console.WriteLine();
        Console.WriteLine("Program is finished. Press Enter to exit");
        Console.ReadLine();

    }
    public class nameGen
    {
        public void read()
        {
            string thing;
            int choice;
            string suf;
            string loop = "y";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to the name generator");
            while (loop == "y")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Name a thing");
                string str = Console.ReadLine();
                thing = str;
                Console.WriteLine();
                Console.WriteLine(thing + " it shall be...");
                if (thing.Length > 3)
                {
                    thing = thing.Remove(thing.Length - 2);
                }
                if (thing.Length > 3)
                {
                    thing = thing.Remove(thing.Length - 2);
                }
                if (thing.Length > 3)
                {
                    thing = thing.Remove(thing.Length - 2);
                }
                if (thing.Length == 3)
                {
                    thing = thing.Remove(thing.Length - 1);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please pick a number that corresponds to the character");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("|       1      |        2        |    3   |      4       |  5   |   6   |");
                Console.WriteLine("|Standard Male | Standard Female | Heroic | Ancient Hero | Evil | Alien |");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("|  7    |      8      |   9  |  10   |    11    |    12  |");
                Console.WriteLine("|Exotic | Exotic Hero | Wild | Royal | Powerful | Divine |");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("|  13    |    14    |   15  |   16   |   17   |   18  |");
                Console.WriteLine("|Ancient | Schollar | Youth | Secret | Lively | Order |");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("| 19  |    20      |     21    |    22    |    23    |");
                Console.WriteLine("|Wise | Mastermind | Protector | Daughter | Commoner |");
                Console.WriteLine("-----------------------------------------------------------------------------");
                string cho = Console.ReadLine();
                choice = int.Parse(cho);
                if (choice == 1)
                {
                    string[] names = new string[] { "on", "o" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);

                }
                if (choice == 2)
                {
                    string[] names = new string[] { "a", "ea", "lia" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 3)
                {
                    string[] names = new string[] { "ion", "ian", "an" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 4)
                {
                    suf = "ul";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 5)
                {
                    string[] names = new string[] { "roth", "oth", "or" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 6)
                {
                    string[] names = new string[] { "u", "lu" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 7)
                {
                    string[] names = new string[] { "ïr", "ur", "lash", "ath" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 8)
                {
                    string[] names = new string[] { "ehal", "ahal", "ihal" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 9)
                {
                    string[] names = new string[] { "th", "eth" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 10)
                {
                    string[] names = new string[] { "ys", "us" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 11)
                {
                    string[] names = new string[] { "kor", "or", "oth" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                //other half
                if (choice == 12)
                {
                    string[] names = new string[] { "iel", "el" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 13)
                {
                    string[] names = new string[] { "hothep", "ot", "ut" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 14)
                {
                    suf = "ic";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 15)
                {
                    suf = "thy";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 16)
                {
                    suf = "al";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 17)
                {
                    suf = "in";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 18)
                {
                    suf = "ix";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 19)
                {
                    suf = "ynne";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 20)
                {
                    suf = "oe";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 21)
                {
                    suf = "dan";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 22)
                {
                    suf = "ra";
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                if (choice == 23)
                {
                    string[] names = new string[] { "erd", "rd" };
                    Random rnd = new Random();
                    int index = rnd.Next(names.Length);
                    suf = names[index];
                    Console.WriteLine();
                    Console.WriteLine("The name of your character is: " + thing + suf);
                }
                Console.WriteLine("Would you like to make another character? (y/n)");
                loop = Console.ReadLine();
            }

            
        }
    }

}