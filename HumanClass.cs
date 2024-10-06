 class Human
    {
        


        //Characteristic of Human
        public String name;
        public int age;

        // Constructor : A Special method in a class,
        //               Same name as the class name
        //              Can be used to assign arguments to fields when creating an object
        public Human(String name, int age){
            this.name = name;
            this.age = age;
        }


        // Action Human Can Perform
        public void Eat(){
            Console.WriteLine(name + " is eating");
        }
        public void Sleep(){
            Console.WriteLine(name + " is sleeping");
        }
    }
