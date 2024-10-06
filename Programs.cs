using System;


namespace cSharpBasic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Word");

            /* This is
            a way
            to declare
        variable 
            */

            /**

        int x; // Declaration
        x = 24 ; //Initialization

        int y = 45; //Declaration + Initialization // int store whole numbers
        double height = 11.09; // store decimal number
        bool alive = true;    // store true or false
        char symbol =  '@'; // store only one character
        string firstName = "Timilehin";

        Console.WriteLine("The Sum of X and Y is given " + (x+y));
        Console.WriteLine("Your height is " + height + " cm");
        Console.WriteLine("Are you alive?  " + alive );
        Console.WriteLine("Your Favorite special character is " + symbol );
        Console.WriteLine("My name is " + firstName );


        String username = symbol + firstName;

        Console.WriteLine("Your Username is " + username);

        */

        /* 
        Constant = immutable values which aare known at compile time
                and do not change for the rest of the life of the program
        */

        // const double pi = 3.153;

         /* 
        type casting  = Converting a value to a different data type, 
                    Usefull when we accept user input (String)
                    Different data type can do different things
        */

/*
        int pie = Convert.ToInt32(pi);

        Console.WriteLine(pie);


        Console.WriteLine(pie.GetType());

        */

        // *****Take User Input ////////// 

        // Console.WriteLine("What is your name?");
        // String name = Console.ReadLine();

        
        // Console.WriteLine("How old are you?");
        // int age = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Your name is " + name);
        // Console.WriteLine("You are  " + age + " years old");

        // *****BASIC ARITHEMETICS ////////// 

        // int friends = 8;

        // friends = friends + 4; // Stardarnd Way
        // friends += 4; // Short Cut
        // friends++; // increment by 1 used in loops
        

        // friends = friends - 4; // Stardarnd Way
        // friends -= 4; // Short Cut
        // friends--; // increment by 1 used in loops

        
        // friends = friends * 4; // Stardarnd Way
        // friends *= 4; // Short Cut

        // friends = friends / 4; // Stardarnd Way
        // friends /= 4; // Short Cut

        // int remainder = friends % 5; // modulo operation
       


        // Console.WriteLine("friends: " + friends);
        // Console.WriteLine("friends: " + remainder);

        /* Basic Mathematics
        double  x = 3.14159;
        double  y = 7;

        double a = Math.Pow(x, 2);
        double b = Math.Sqrt(x);
        double c = Math.Round(x);
        double d = Math.Floor(x);
        double e = Math.Ceiling(x);
        double f = Math.Max(x, y);
        double g = Math.Min(x, y);

        Console.WriteLine(g);

        */

/*
        Random NUMBER GENERATION

        Random randomNumber = new Random();

        int num = randomNumber.Next(1, 11);
        double num = randomNumber.NextDouble();

        Console.WriteLine(num);
        */

        /* Program to fine the hypothesis of a triangle
        Console.WriteLine("Please Enter Side A");
        int sideA = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Please Enter Side B");
        int sideB = Convert.ToInt32(Console.ReadLine());

        Double Hypothenus = Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));

        Console.WriteLine(Hypothenus);

        */

        /*String Methods

        String fullName = "Olanrewaju Timilehin" ;
        String phoneNumber = "123-456-789";

        // fullName = fullName.ToUpper();
        fullName = fullName.ToLower();

        Console.WriteLine(fullName);
        Console.WriteLine(phoneNumber.Replace("-", "/"));
        Console.WriteLine(fullName.Length);

        String firstName = fullName.Substring(0, 10);
        String lastName = fullName.Substring(11, 9);
        Console.WriteLine("Your First Name: " + firstName + "\nYour Last Name: " + lastName);

        */

        /*IF STATEMENTs ARE NOT NULL
        Console.WriteLine("Hello, There! How old are you?");

        int age = Convert.ToInt32(Console.ReadLine());

        
        if (age >= 18)
        {
            Console.WriteLine("You're authorized to view this page");
        }else
        {
            Console.WriteLine("You're authorized to view this page");
            
        }
        */

        /* SWITCH STATEment

        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();
        
        switch (day)
        {
            case "Sunday":
            Console.WriteLine("Today is Sunday");
            break;
            case "Monday":
            Console.WriteLine("Today is Monday");
            break;
            case "Tuesday":
            Console.WriteLine("Today is Tuesday");
            break;
            case "Wednesday":
            Console.WriteLine("Today is Wednesday");
            break;
            case "Thursday":
            Console.WriteLine("Today is Thursday");
            break;
            case "Friday":
            Console.WriteLine("Today is Friday");
            break;
            case "Saturday":
            Console.WriteLine("Today is Saturday");
            break;
            
            default:
            Console.WriteLine(day + " is not a day");
            break;

        }

        */

        /* LOGICAL OPERATORS

        Console.WriteLine("What temperature is outside: (C)" );
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (temperature >= 0  && temperature <= 10)
        {
          Console.WriteLine("It too cold outside");  
        }else if (temperature >10 && temperature <= 34)
        {
          Console.WriteLine("It quite warm outside");  
            
        }
        else if(temperature <=0 || temperature >= 100)
        {
          Console.WriteLine("PLEASE DO NOT GO OUTSIDE3");  

        }

        */

        // WHiLE LOOPS

        /* While loop will continue until the runnuing while the condition s remains true

        // Console.ReadKey();
        String name = "";

        while (name == "")
        {
            Console.Write("Please Enter Your Name! ");
            name = Console.ReadLine();
        }

        Console.Write("Hello " + name );

        int number = 0;

        while (number < 8)
        {
            number++;
        Console.Write(number);
        }

        */



/* FOR LOOP : WILL REPEAT A CODE FOR FINITE AMOUNT OF TIMES

    // for (int i = 0; i > 10; i++)
    // {
    //     Console.WriteLine(i);
        
    // }

    // Countdown to Happy New Year

   for (int i = 10; i > 0; i--)
    {
        Console.WriteLine(i);
        
    }
    */

    /* NESTED LOOPS NESTED FOR LOOP

    Console.Write("How many rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());     

    Console.Write("How many columns: ");
    int columns = Convert.ToInt32(Console.ReadLine()); 

    Console.Write("What symbols: ");
    String symbols = Console.ReadLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write(symbols);
        }        
        Console.WriteLine(symbols);

    }

    */

    /*  Number Guessing Game
    Random random = new Random();
    bool playAgain = true;
    int min = 1;
    int max = 100; 
    int guess; 
    int number;
    int guesses;
    String response;

    while (playAgain)
    {
        guess = 0;
        guesses = 0;
        number = random.Next(min, max + 1);
        response = "";

        while (guess != number)
        {
            Console.WriteLine("Hello, Please Guess a number between " + min + " and " + max + number);
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You Guessed Number: " + guess);



            if (guess > max)
            {
                Console.WriteLine(guess + " Is Way Too High!, Please Try Again");
            }else if (guess > number)
            {
                Console.WriteLine(guess + " Is Too High!, Please Try Again");
            }else if (guess < number)
            {
                Console.WriteLine(guess + " Is Too Low!, Please Try Again");
            }
            guesses ++;
        }
        Console.WriteLine("Number: " + number);
        Console.WriteLine("You Won!");
        Console.WriteLine("You Made a total of " + guesses + " guesses");

        Console.WriteLine("Would you like to play again? (Y/N): ");
        response = Console.ReadLine();
        response = response.ToUpper();

        while (response != "Y")
        {
             if (response == "Y" || response == "YES")
        {
            playAgain = true;
        }
        }

        Console.WriteLine("Thanks for playing");

    }
        // */

        /* Simple Calculator with Do while
        do
        {
        double number1, number2, result = 0;
        String response = "";

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A Basic Calculator Program");
        Console.WriteLine("------------------------------------------");

        Console.Write("Enter Number 1: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Basic Arithmetic Operations");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Substract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");

        Console.Write("Enter Operation : ");
        String operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
            result = number1 + number2;
            // This below is a String Interpolation
            // StringInterpolation : allow us to insert values/variables into a String
                // literal preceded by a String literal $ {} are placeholder
            Console.WriteLine($"Your result : {number1} + {number2} =  {result}");
            break;
            case "-":
            result = number1 - number2;
            Console.WriteLine($"Your result : {number1} - {number2} =  {result}");
            break;
            case "*":
            result = number1 * number2;
            Console.WriteLine($"Your result : {number1} * {number2} =  {result}");
            break;
            case "/":
            result = number1 / number2;
            Console.WriteLine($"Your result : {number1} / {number2} =  {result}");
            break;
            default:
            Console.WriteLine("Invalid Operation, Please try again");
            break;
        }
        Console.WriteLine("Would you like to continue? (Y = Yes, N = No): " );
        }while ( Console.ReadLine().ToUpper().Trim() == "Y" );

        Console.WriteLine("Bye!");
*/
        /*
        do
        {
        double number, result = 0;
        String response = "";

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A Basic Calculator Program To Find Square And Square Root Solution");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Basic Operations");
        Console.WriteLine("\t(a) : Square");
        Console.WriteLine("\t(b) : Square root");

        Console.Write("Enter Operation : ");
        String operation = Console.ReadLine();

         if (operation == "a" || operation == "A")
        {
            Console.Write("Find the Square of : ");
            
        }else if (operation == "b" || operation == "B")
        {
            Console.Write("Find the Square Root of : ");
            
        }

       
        number = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case "a":
            result = Math.Pow(number, 2) ;
            Console.WriteLine($"The Square of : {number} =  {result}");
            break;
            case "b":
            result = Math.Sqrt(number) ;
            Console.WriteLine($"The Square Root of : {number} =  {result}");
            break;
            default:
            Console.WriteLine("Invalid Operation, Please try again");
            break;
        }
        Console.WriteLine("Would you like to continue? (Y = Yes, N = No): " );
        }while ( Console.ReadLine().ToUpper().Trim() == "Y" );

        Console.WriteLine("Bye!");
        */

        /* Array = A variable that can store multiple values. <Fixed Size>

        String[] cars = new String[4];

        // String[] cars = {"BMW", "MUSTANG", "TOYOTA"};

        cars[0] = "BMW";
        cars[1] = "Tesla";
        cars[2] = "MUSTANG";
        cars[3] = "TOYOTA";
    

        for (int i = 0; i < cars.Length; i+=2)
        {
        Console.WriteLine( cars[i]);
            
        }

        // Console.WriteLine( cars[0]);
        */

        /* For Each Loop: is a simpler way to iterate over an array, but less flexible

        String[] cars = {"BMW", "MUSTANG", "TOYOTA"};

        foreach (var car in cars)
        {
        Console.WriteLine( car);
        }

        */

        /* Methods:  performs a section of code, whenever it is called or "invoved"
        //          benefits = Let's us reuse code w/o rewriting it multiple times

        String [] name = {"timi", "Seun", "Duchess", "Paul"};
        int [] age = [23, 21, 32, 44];

        for (int i = 0; i < name.Length; i++)
        {
        singHappyBirthday(name[i], age[i]);
            
        }
        
        // singHappyBirthday(name, age);
        // singHappyBirthday(name, age);

        */

        /* Return : returns data back to the place where a method was "invoked"
        double x, y, result;

        Console.Write("Enter Number 1 : ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number 2 : ");
        y = Convert.ToDouble(Console.ReadLine());

        result = Multiply(x, y);
        Console.WriteLine(result);

        */

        // param keyword : a method parameter that takes a variable number of arguments
        //                  The Parameter type must be a single - dimensional array
        // Alternatively, is Method OverLoad which i did not not because of complexity
        // Param Keyword is betteer
/*
        double total = CheckOut(3.99, 4.33);
        Console.WriteLine(total);
    }
    */
    /* Multidemensional Array

    String[] ford = { "Mustang", "F-150", "Explorer"};
    String[] chevy = { "Corvette", "Camaro", "Silverado"};
    String[] toyota = { "Corolla", "Camry", "Rav4"};

    String[,] parkingLot = {{"Mustang", "F-150", "Explorer"},
                            { "Corvette", "Camaro", "Silverado"},
                            { "Corolla", "Camry", "Rav4"}
    };
    // parkingLot[2, 1] = "Fusion";

    // foreach (String cars in parkingLot)
    // {
    //     Console.WriteLine(cars);
    // }

    for (int i = 0; i < parkingLot.GetLength(0); i++)
    {
        for (int j = 0; j < parkingLot.GetLength(0); j++)
        {
        Console.WriteLine(parkingLot[i, j] + " " );
        }
        System.Console.WriteLine();
    }
Math.Round(0.333);

        */

        /* Class : A bunch of related codes, can be used as a blueprint to create objects(oop)

        // Messages.Hello();
        // Messages.Waiting();
        // Messages.Bye();
        */

        /* Object : An Instance of a class
        //         A class can be used as a blueprint to create objects(OOP)
        //         objects can have fields and methods(characteristics and actions)

        Human human1 = new Human("Timi", 21);
        // human1.name = "Timi";
        // human1.age = 21;

        human1.Eat();
        human1.Sleep();

         Human human2 = new Human("Yomi Joshua", 44);
        // human2.name = "Yomi Joshua";
        // human2.age = 44;

        human2.Eat();
        human2.Sleep();

        */

        /* Instantiate name of class
        Car car1 = new Car("Ford", "Mustang", "red", 1997);
        car1.Drive();

        Car car2 = new Car("Chevvy","Corvette", "pink", 2002 );
        car2.make = "GLE";
        car2.model = "L250";
        car2.color = "pink";
        car2.year = 2002;

        car2.Drive();

        */

        /* Static : modifier to declare a static member, which belongs to the class itself
                // rather than to any specific object
                // Can be applied to a field, method, or a class itself

        Car car1 = new Car("Mustang");
        Car car2 = new Car("Chevvy");
        Car car3 = new Car("Chevvy");

        System.Console.WriteLine(Car.numbersOfCar);
        Car.StartRace();
*/

    /* Inheritance : 1 or more classes recieve fields, methods, etc from a common parent class
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.Go();

        Console.WriteLine(bicycle.speed);
        Console.WriteLine(bicycle.wheels);
        bicycle.Go();
        */

        /* Abstract Classes : modifiers that indicate missing components or incomplete implementations
           // if there a class, you do not want to instantiate an object from, just preseed with abstract keyword
        // They you cannot create objects from that class. E.g The Vehicle class in this example

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        // Vehicle vehicle = new Vehicle();

        */

        /* Array Of Objects

        // Car[] garage = new Car[3];

        // Car car1 = new Car("Mustang");
        // Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");

        // garage[0] = car1;
        // garage[1] = car2;
        // garage[2] = car3;

        //Alternatively we could do; using annonymous objects
        // this will exactly as the above code
        Car[] garage = {new Car("Mustang"),new Car("Corvette"), car3  };

        foreach (Car car in garage)
        {
        Console.WriteLine(car.model);
            
        }

        // Console.WriteLine(garage[0].model + " " + garage[1].model + " " + garage[2].model);
        */

        /* Pasing an object as an Argument 

        Car car1 = new Car("Ford");
        Console.WriteLine(car1.model);

        ChangeModel(car1, "Ferrari");
        Console.WriteLine(car1.model);

        */
        /*
        Car car1 = new Car("Ford");
        Car car2 = Copy(car1);

        Console.WriteLine(car2.model);

        */

        // Method Overridding : Provides a new version of a method inherited from a parent class
                        //Inherted method must be; abstract, virtual or already overridden 
                        // Used with ToString(), polymorphism

        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Speak();
        cat.Speak();



        Console.ReadKey();
        
        /*
        static double CheckOut(params double[] prices)
        {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        } 
        return total;
        }
        */
        
        /*
        
        static Double Multiply(Double x, Double y){
        return x * y;
        }
        */
        
        /* static void singHappyBirthday(String celebrantName, int yearsOld){
        Console.WriteLine("Happy birthday to you" );
        Console.WriteLine("Happy birthday dear " + celebrantName);
        Console.WriteLine("How old are you now?" );
        Console.WriteLine($"You are {yearsOld} years old" );
        Console.WriteLine("Hip! Hip!! Hip!!!, Hurray!!!" );
        Console.WriteLine();
    } */
    }

    /* method to Change an existing object
    public static void ChangeModel(Car car,String model){
    car.model = model;
    } 

    */

    /* method to Change an existing object
    public static void ChangeModel(Car car,String model){
    car.model = model;
    } 

    */

     public static Car Copy(Car car){
    return new Car(car.model);
    } 

    // class Human
    // {
    //     //Characteristic of Human
    //     public String name;
    //     public int age;

    //     // Action Human Can Perform

    //     public void Eat(){
    //         Console.WriteLine(name + " is eating");
    //     }
    //     public void Sleep(){
    //         Console.WriteLine(name + " is sleeping");
    //     }
    // }
}