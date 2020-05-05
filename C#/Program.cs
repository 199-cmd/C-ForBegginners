 using System;
 using System.Linq;
 namespace My Application
 {
    class Program
    {
        static void Main(string[] args)
        {
                      /*
            //DataTypes
            int num = 5;
            double value = 5.99D;
            char val = 'h';
            bool mybool = true;
            string str = "Nityanand";
            Console.WriteLine(num);
            Console.WriteLine(value);
            Console.WriteLine(val);
            Console.WriteLine(mybool);
            Console.WriteLine(str);
            */

            /*
            //take a Input
            Console.WriteLine("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is "+age);
            */
            /*

            //String
            string name = "Nityanand";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            */

            /*
            //String concatenation
            string Firstname = "Nitya";
            string LastName = "Kumar";
            //Console.WriteLine("Your full name is " +Firstname+LastName);
            string result = string.Concat(Firstname, LastName);
            Console.WriteLine(result);
             */

            //Conditional statement
            /*
            int a=5,b=6,c=7;
            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
            Console.ReadKey();
            */

            //Ternary operator
            /*
            int time = 20;
            string result = (time < 22) ? "Good day" : "Good evening";
            Console.WriteLine(result);
            Console.ReadKey();
            */

            //Switch case
            /*
            int choice;
            Console.WriteLine("Enter your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            { 
                case 2:
                    Console.WriteLine("Dosa");
                    break;
                case 3:
                    Console.WriteLine("Samosa");
                    break;
                case 4:
                    Console.WriteLine("paneer");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
               
            }
            Console.ReadKey();
             */

            //Looping
            /*
            int[] num = { 2, 5, 4, 7 };
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
             */

           //Array
            /*
            int[] num = { 5, 8, 7, 5, 9, 8, 7, 4 };
            Array.Sort(num);
            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());
            Console.WriteLine(num.Sum());
         
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            

            string[] fruits = { "Banana", "Grapes", "Cherry" };
            for(int i= 0;i<fruits.Length;i++)
            {
                Console.WriteLine(fruits[i]);
            }
    
            */
            //string[] name = new string[6];
            //string[] name = new string[3] { "Nitya", "Rohan", "Roshan" };
            //string[] name = new string[] { "Nitya", "Rohan", "Roshan" };
           /*
            //Class and Object
            class Demo
            {
                string name = "NItyanand";
                void show()
                {
                    Console.WriteLine("This is a method");
                }
                static void Main(string[] args)
                {
                    Demo obj = new Demo();
                     Console.WriteLine(obj.name);
                    obj.show();
                }
            }

            //Constructor
            class Demo
            {
                public string name;
                Demo()//Default Constructor
                {
                    name = "Nitya";
                }
                static void Main(string[] args)
                {
                    Demo obj=new Demo();
                    Console.WriteLine(obj.name);
                }
            }

            //Parameterize Constructor
            class Demo
            {
                public string name;
                Demo(string newName)//Default Constructor
                {
                    name = newName;
                }
                static void Main(string[] args)
                {
                    Demo obj=new Demo("NItyanand");
                    Console.WriteLine(obj.name);
                }
            }

            //Inheritance
            class Demo
            {
                void show()
                {
                    Console.WriteLine("Hello Demo");
                }
                static void Main(string[] args)
                {
                    b obj=new b();
                     obj.display();
                    obj.show();

                    Console.WriteLine();
                }
            }
            class b: Demo
            {
                public void display()
                {
                    Console.WriteLine("I am b");
                }
            }

            //Another Example with this keyword
            class Demo
            {
                public string name;
                public int roll;
                public void data(string name,int roll)
                {
                    this.name = name;
                    this.int = roll;
                    Console.WriteLine(name + " " +roll);
                }
                static void Main(string [] args)
                {
                    b obj = new b();
                    obj.data("Nityanand",40);
                    Console.ReadLine();
                }
            }
            class b : Demo
            {
                public void display()
                {
                    Console.WriteLine("I am b");
                }
            }

            //Polymorphism

            class Demo
            {
                public virtual void show()
                {   
                    Console.WriteLine("I am Show method");
                }
                static void Main(string[] args)
                {
                    Demo obj1 = new Demo();
                    b obj2 = new b();
                    c obj3 = new c();
                    obj1.show();
                    obj2.show();
                    obj3.show();
                }
            }
            class b : Demo
            {
                public override void show()
                {
                    Console.WriteLine("I am show method Again");
                }
            }
            class c : Demo
            {
                public override void show()
                {
                    Console.WriteLine("I am show method Again and again");
                }
            }

            //Abstraction 
            // a)Abstract class
            // b)Interface
            
            abstract class Demo
            {
                public void children();
                public void show()
                {
                    Console.WriteLine("this is normal method");
                }
                static void Main(strinf[] args)
                {
                    family obj = new family();
                    obj.children();
                    obj.show();
                    Console.ReadLine();
                } 
            }
            class family : Demo
            {
                public override void children()
                {
                    Console.WriteLine("I am Defination");
                }
            }

            //Interface
            interface Person
            {
                void child();
                void family();

            }
            class temporary : person
            {
                public void child()
                {
                    Console.WriteLine("this is child");   
                }
                public void family()
                {
                    Console.WriteLine("");
                }
                static void Main(strinf[] args)
                {
                   temporary obj=new temporary();
                    obj.child();
                    obj.family();
                    Console.ReadLine();
                }
            }

            //Enumeration abbrviatation as enum
            used to 
            enum Company
            {
                GOOGLE,
                MICROSOFT,
                APPLE
            }
            class Demo
            {
                static void Main(string[] args)
                {
                    Demo obj = Company.GOOLE;
                    Console.WriteLine(obj);
                    Console.ReadLine();
                }
            }
           */  
        }
    }
}


        