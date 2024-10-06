//  class Car
//     {
//         //Characteristic of Car
//         public String make;
//         public String model;
//         public String color;
//         public int year;

//         // Constructor : A Special method in a class,
//         //               Same name as the class name
//         //              Can be used to assign arguments to fields when creating an object
//         public Car(String make, String model, String color, int year){
//             this.make = make;
//             this.model = model;
//             this.color = color;
//             this.year = year;
//         }


//         // Action Human Can Perform
//         public void Drive(){
//             Console.WriteLine( $"You drive the {make} {model}" );
//         }
//     }

/*
    class Car
    {
        String model;
        public static int numbersOfCar;
        public Car(String model){
            this.model = model;
            numbersOfCar++;
        }
        public static void StartRace(){
            Console.WriteLine("The race is starting soon");
        }
    }
    */
    /* Inheritance  
    class Vehicle
    {
        // Here is a Class called Vehicle with "speed" field and a "Go" method 
        // With three Children Class; Car, Bicycle and Boat
        public int speed = 0;
        public void Go()
        {
            Console.WriteLine("The vehicle is Moving");
        }
    }
    class Car : Vehicle{
        public int wheels = 4;

    }
    class Bicycle : Vehicle{
        public int wheels = 2;

    }
    class Boat : Vehicle{
        public int wheels = 0;
    }
    */

     /* Abstract  
    abstract class Vehicle
    {
        // Here is a Class called Vehicle with "speed" field and a "Go" method 
        // With three Children Class; Car, Bicycle and Boat
        public int speed = 0;
        public void Go()
        {
            Console.WriteLine("The vehicle is Moving");
        }
    }
    class Car : Vehicle{
        public int wheels = 4;
        int maxSpeed = 500;

    }
    class Bicycle : Vehicle{
        public int wheels = 2;
        int maxSpeed = 50;

    }
    class Boat : Vehicle{
        public int wheels = 0;
        int maxSpeed = 260;
    }

    */
    

    // Arrays of Objects
    class Car
    {
        public String model;
        public Car(String model){
            this.model = model;
        }
    }
    
