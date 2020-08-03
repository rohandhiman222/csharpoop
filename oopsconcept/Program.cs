using System;

namespace oopsconcept
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0}, I am {1}", to, Name);
        }

        public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
        
        public static Person ParseStatic(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Person person = new Person();
            // var person = new Person();
            // person.Name = "Sonali";
            // person.Parse("Nisha");

            var person = Person.ParseStatic("good bye");
            
            person.Introduce("rohan");



            /*
             * What is a class?
             *     A building block of an application.
             *     applications have multiple classes
             * Real world example
             *     Presentation                 PostView class only responsible for view 
             *     Business Logic / Domain      Post
             *     Data Access / Persistence    Post Repository
             *
             *
             *  Real-world example of classes.
             *  Anatomy of a class
             *         Person Class                                    Object
             *     * Data (represented by fields)                        John
             *     * Behaviour (represented by methods / functions)      Rohan
             *  class example in uml is graphical language
             *     Name: String
             *     Age: byte
             *     Height : float
             *     Weight : byte
             *-----------------------------
             *     Walk()
             *     Talk()
             *     Eat()
             *     Sleep()
             *
             * Another example
             *      Post
             *   Title : string
             *   Description : string
             *   DateTime : DateTime
             * ----------------------
             *   Publish()
             *   Like()
             *   Comment(message)
             * 
             *
             * What is an object.
             *     An instance of a class
             *     
             *
             * Static memebers
             * 
             */


            /*
               Declaring Classes
               public class Person {}
               
               Naming Conventions
               Pascal Case First latter should be capital
               Camel Case first latter should be lower case after that second latter should be capital latter
              
              public class Person {
                 public string Name;
                 
                 public void Introduce(){
                     Console.WriteLine("Hi my name is " + Name);
                 }
              }
              
              Person person = new Person();
              
              var person = new Person(); // better way use var not dupplicated
               
               person.Name = "rohan";
               
               person.Introduce();
               
     
     * Class have two type of Members 
             * Instance : accessible from an object
               var person = new Person();
               person.Introduce();
               
             * Static: accessible from the class.
               Console.WriteLine(); // not created object Console is class
      
      
      * Why use static members?
             * To represent concepts that are singleton
             *  DateTime.Now
             * Console.WriteLine()
      
      
      * Declaring Static Memebers
             public class Person{
                 public static int PeopleCount = 0;
             
             }
              
             */
             
             
             
             
/* What is a constructors ?
 *     A method that is called when an instance of a class is created.
 *     
 *
 *
 * 
 */             



        }
    }
    
    
}