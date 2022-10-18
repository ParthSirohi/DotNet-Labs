using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using OOPS;
class Program
{
    public delegate void PM(string requirement);
    static void Main()
    {
        Thread t1 = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hand Movement:: x-coordinate={i}");
            }
        });
        t1.Name = "Hand Animation";

        Thread t2 = new Thread(() =>
        {
            for (int i = 1000; i > 0; i--)
            {
                Console.WriteLine($"Ball Movement:: y-coordinate={i}");
            }
        });
        t2.Name = "Ball Animation";
        //Start the thread
        t1.Start();
        t2.Start();
        Thread.Sleep(3000);
        Console.ForegroundColor=ConsoleColor.DarkYellow;
        Console.WriteLine("========The game has completed!========");

        }

    private static void LinqLambdaL2()
    {
        //Collection of Rectangles
        List<Rectangle> rectangle = new List<Rectangle>();
        rectangle.Add(new Rectangle(10, 5));
        rectangle.Add(new Rectangle(10, 3));
        rectangle.Add(new Rectangle(20, 7));
        rectangle.Add(new Rectangle(25, 5));
        //Query get all rectangles whose length=10
        //get all rectangles whose breadth =3
        //get all rectangles whose length=10 breadth =5
        //get all rectangles whose area >50
        rectangle.Where((r) => { return r.Length == 10; })
            .ToList()
            .ForEach((r) => { Console.WriteLine($"Length: {r.Length} Breadth: {r.Breadth} "); });

        //using LINQ
        var searchedRectangles = from r in rectangle
                                 where r.Length == 10
                                 select r;
        //Display
        searchedRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth:: {r.Length} X {r.Breadth}");
            });

        rectangle.Where((r2) => { return r2.Length == 10 && r2.Breadth == 5; })
            .ToList()
            .ForEach((r2) => { Console.WriteLine($"Length: {r2.Length} Breadth: {r2.Breadth} "); });

        //using LINQ
        var searchedRectangles2 = from r2 in rectangle
                                  where r2.Length == 10 && r2.Breadth == 5
                                  select r2;
        //Display
        searchedRectangles2
            .ToList()
            .ForEach((r2) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length is 10 and Breadth is 5:: {r2.Length} & {r2.Breadth}");
            });
    }

    private static void LINQ(List<string> names)

    {
        //List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Reena Chakravarthy");


        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });
        // List<string> result = names.Where((str) =>
        //{
        //   return str == "Reena";
        //}).ToList();

        //Console.WriteLine("Search for Reena");
        //result.ForEach((str) =>
        //{
        //   Console.WriteLine($"Found match for: {str}");
        //});
        List<string> result2 = names.Where((str) =>
        {
            return str.StartsWith("Re") && str.EndsWith("thy");
        }).ToList();
        Console.WriteLine("Search for Re");
        result2.ForEach((str) => Console.WriteLine($"Found Match for Re: {str}"));

        //LINQ => Language Integrated Query == SQL in .Net
        Console.WriteLine("----LINQ-----");
        var queryOutput = (from str2 in names
                           where str2 == "Reena" && str2.Contains("Chakravarthy")
                           select str2).ToList();
        queryOutput.ForEach((str2) => { Console.WriteLine(str2); });
    }

    private static void Satish(string requirement)
    {
        Console.WriteLine("I, Satish attended the tax Training");
    }

    private static void Izhan(string requirement)
    {
        Console.WriteLine("I, Izhan attended the tax Training");
    }

    private static void Parth(string requirement)
    {
        Console.WriteLine("I, Parth attended the tax Training");
    }
}