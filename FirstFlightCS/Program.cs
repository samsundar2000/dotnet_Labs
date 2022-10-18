// See https://aka.ms/new-console-template for more information
using System;
using oops;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Xml.Schema;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        IEmpContract sam = new KpmgEmployee();
        Console.WriteLine("Sick Leave Clause for Sam (KPMG): "+sam.SickLeaveClase());
        Console.WriteLine("Work hour Clause for Sam (DELL): "+sam.WorkHoursClause());
        Console.WriteLine();
        IEmpContract sundar = new DellEmployee();
        Console.WriteLine("Sick Leave Clause for Sundar (DELL): "+sundar.SickLeaveClase());
        Console.WriteLine("Work hour Clause for Sundar (DELl): "+sundar.WorkHoursClause());
      /*  Shape sh = new Circle() { Radius = 5};
        sh.Draw();
      */
        //VirtualMethod();
        //UseOverLoading();
        //NewMethod1();
        //UseArithmeticOperation();
        //DataType();
        /* Console.WriteLine("Enter the food you want to order: ");
         string food = Console.ReadLine();
         CalculateGst(food);
        Console.WriteLine("Enter the cost of food: ");
        int cost = Convert.ToInt32(Console.ReadLine());
        */

        /* var currency = 100d;
        decimal deCurrency = (decimal)currency; //type casting
        string s = "100";
        int num = Convert.ToInt32(s); //type conversion
        */
        //DefaultAndNullable("coding", null);
        //DefaultAndNullable("Training", "Angular", true);
        /*var empId = 1001;
        Execute("storedProc", "Name: spSelectAll");
        Execute("query", "select * from emp", "where id = " + empId);
        */
        /*Rectangle r1 = new Rectangle(15, 10);
        float area = r1.CalculateArea();
        Console.WriteLine("Area of "+r1.Name+" with length "+r1.Length+ " and breadth "+r1.Breadth+" is: "+area);
        Square sq1 = new Square(20);
        area = sq1.CalculateArea();
     
        Console.WriteLine("Area of "+sq1.Name+" with length " + sq1.Length + " and breadth " + sq1.Breadth + " is: " + area);
        */
    }

    private static void VirtualMethod()
    {
        // Base  class = new DerivedClass();
        Parent Meena = new Child();
        Meena.ChooseCareer(); //with permission overriding
        Meena.NoNightOuts(); //without permission hiding

        Child child = new Child();
        child.NoNightOuts(); //child's function will be called
    }

    private static void UseOverLoading()
    {
        ToDo myTodo = new ToDo()
        {
            Name = "Coding",
            StartDate = DateTime.Now.AddDays(-15),
            EndDate = DateTime.Now.AddDays(15),
            IsCompleted = false
        };
        myTodo.Create(0);
        myTodo.Name = "Angular Training";
        myTodo.StartDate = DateTime.Now.AddDays(-10);
        myTodo.EndDate = DateTime.Now.AddDays(-4);
        myTodo.IsCompleted = true;

        myTodo.Create(1);
        myTodo.ViewTodos();
        myTodo.ViewTodos("Coding");
    }

    private static void Execute(params string[] p1) //infinite number of parameters
    {
        Console.WriteLine("Execution Details: ");
        for(int i=0;i< p1.Length; i++)
        {
            Console.WriteLine(p1[i]);
        }
    }
    private static void DefaultAndNullable(string task, string? details, bool isCompleted = false) // ? null is allowed
    {
        Console.WriteLine(task);
        Console.WriteLine(details);
        Console.WriteLine(isCompleted);
    }

    private static void CalculateGst(string food)
    {
        int noodles = 200;
        int friedRice = 150;
        int totalCost = 0;
        switch (food)
        {
            case "noodles":
                totalCost = totalCost + 200;
                double gst = totalCost * 0.18;
                double toPay = gst + totalCost;
                Console.WriteLine("The GST for the ordered food is: " + gst);
                Console.WriteLine("The total ammount to be paid is: " + toPay);
                break;
            case "friedRice":
                totalCost = totalCost + 150;
                double gst1 = totalCost * 0.18;
                double toPay1 = gst1 + totalCost;
                Console.WriteLine("The GST for the ordered food is: " + gst1);
                Console.WriteLine("The total ammount to be paid is: " + toPay1);
                break;
            default:
                Console.WriteLine("The food is out of stock");
                break;

        }
        
    }
    
    private static void DataType()
    {
        int num = 100;
        double doubleNum = 100d;
        float floatNum = 100f;
        decimal decimalNum = 100m;
        Console.WriteLine("Datatype of intNum is " + (num.GetType().ToString()));
        Console.WriteLine("Datatype of doubleNum is " + (doubleNum.GetType().ToString()));
        Console.WriteLine(typeof(int)); //to get the type of a datatype.
    }

    private static void UseArithmeticOperation()
    {
        try
        {
            Calculate(15, 20, "Add");
            Calculate(15, 20, "Subtract");
            Calculate(15, 20, "Multiply");
            Calculate(15, 20, "Divide");
            Calculate(15, 20, "fjasl");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Operation, Please Enter the correct operation: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void NewMethod1()
    {
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your place");
        var place = Console.ReadLine();
        Console.WriteLine("Enter your hobbies");
        var hobbies = Console.ReadLine();
        Console.WriteLine("The person's name is " + name + ". " + name + " lives in Bangalore." +
        name + " hobbies is " + hobbies);
    }

    private static void Calculate(int num1,int num2, string operationType)
    {
        switch (operationType)
        {
            case "Add":
                Console.WriteLine("The Sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
                break;
            case "Subtract":
                Console.WriteLine("The Subraction of " + num1 + " and " + num2 + " is " + (num1 - num2));
                break;
            case "Multiply":
                Console.WriteLine("The Product of " + num1 + " and " + num2 + " is " + (num1 * num2));
                break;
            case "Divide":
                Console.WriteLine("The Division of " + num1 + " and " + num2 + " is " + (num1/num2));
                break;
            default:
                throw new Exception("Wrong Operation");
                //break;
        }
    }


   /* private static void NewMethod()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This code help is a KOOL feature :-)");

        Console.WriteLine("Enter something: ");
        var input = Console.ReadLine();
        Console.WriteLine(input);
        Console.WriteLine("The user value entered is: " + input);  
        Console.WriteLine("Improvised Concatenation: {0}", input); //dotnet old version
        Console.WriteLine($"Latest technique of concatenation: {input}"); //latest version

    }*/
   
}

