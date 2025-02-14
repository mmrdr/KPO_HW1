using System.Runtime.InteropServices;
using System.Threading.Channels;
using ZooManagementApp.Domain.Abstractions;
using ZooManagementApp.Domain.Entities;

namespace ZooManagementApp;

public class Menu
{
    public void RunApp(IZooLogic zoo, IZooFactory zooFactory)
    {
        Console.WriteLine("Welcome to Zoo!");
        ConsoleKey key;
        do
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Add item");
            Console.WriteLine("3. Check zoo state");
            Console.WriteLine("4. Quit menu");
            Console.CursorVisible = false;
            key = Console.ReadKey().Key;
            CheckInput(ref key);
            Console.Clear();
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("What kind of animal you want to add?(type number)");
                    Console.WriteLine("1. Add monkey");
                    Console.WriteLine("2. Add rabbit");
                    Console.WriteLine("3. Add tiger");
                    Console.WriteLine("4. Add wolf");
                    key = Console.ReadKey().Key;
                    CheckInput(ref key);
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            var monkey = CreateAnimal(key, zooFactory);
                            if (monkey != null)
                            {
                                zoo.AddAnimal(monkey);
                            }
                            
                            break;
                        case ConsoleKey.D2:
                            var rabbit = CreateAnimal(key, zooFactory);
                            if (rabbit != null)
                            {
                                zoo.AddAnimal(rabbit);
                            }
                            
                            break;
                        case ConsoleKey.D3:
                            var tiger = CreateAnimal(key, zooFactory);
                            if (tiger != null)
                            {
                                zoo.AddAnimal(tiger);
                            }
                            
                            break;
                        case ConsoleKey.D4:
                            var wolf = CreateAnimal(key, zooFactory);
                            if (wolf != null)
                            {
                                zoo.AddAnimal(wolf);
                            }

                            key = ConsoleKey.Escape; // :)
                            
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("What kind of item you want to add?(type number)");
                    Console.WriteLine("1. Add table");
                    Console.WriteLine("2. Add computer");
                    key = Console.ReadKey().Key;
                    while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
                        key = Console.ReadKey().Key;
                    }
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            var table = CreateThing(key, zooFactory);
                            if (table != null)
                            {
                                zoo.AddInventory(table);
                            }

                            
                            break;
                        case ConsoleKey.D2:
                            var computer = CreateThing(key, zooFactory);
                            if (computer != null)
                            {
                                zoo.AddInventory(computer);
                            }
                            
                            break;
                    }

                    break;
                case ConsoleKey.D3:
                    zoo.Report();
                    break;
            } 
        }while(key != ConsoleKey.D4);
        
    }

    private void CheckInput(ref ConsoleKey key)
    {
        while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.D3 && key != ConsoleKey.D4)
        {
            Console.WriteLine();
            PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
            key = Console.ReadKey().Key;
        }
    }

    private Animal? CreateAnimal(ConsoleKey key, IAnimalFactory animalFactory)
    {
        Console.Clear();
        Console.WriteLine("Input name of animal: ");
        string? name;
        while ((name = Console.ReadLine()) == null)
        {
            PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
        }
        Console.WriteLine("Input food amount: ");
        int food;
        while (!int.TryParse(Console.ReadLine(), out food) || food <= 0)
        {
            PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
        }
        Console.WriteLine("Input animal's identity number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
        }
        
        int kindness;
        if (key == ConsoleKey.D1 || key == ConsoleKey.D2)
        {
            Console.WriteLine("Input level of kindness: ");
            while (!int.TryParse(Console.ReadLine(), out kindness) || kindness <= 0)
            {
                PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
            }
            try
            {
                var animal = animalFactory.CreateAnimal(key.ToString(), food, number, name, kindness);
                return animal;
            }
            catch (ArgumentException e)
            {
                PrintWithColor(e.Message, ConsoleColor.Red);
                return null;
            }
        }
        else
        {
            try
            {
                var animal = animalFactory.CreateAnimal(key.ToString(), food, number, name);
                return animal;
            }
            catch (ArgumentException e)
            {
                PrintWithColor(e.Message, ConsoleColor.Red);
                return null;
            }
        }
    }

    private Thing? CreateThing(ConsoleKey key, IItemFactory itemFactory)
    {
        Console.Clear();
        Console.WriteLine("Input thing's identity number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            PrintWithColor("Incorrect input, try again", ConsoleColor.Red);
        }
        try
        {
            var thing = itemFactory.CreateThing(key.ToString(), number);
            return thing;
        }
        catch (ArgumentException e)
        {
            PrintWithColor(e.Message, ConsoleColor.Red);
            return null;
        }
    }
    private static void PrintWithColor(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;
    }
}