using OopsConAssigment1;

namespace OopsConceptClass2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    Car car = new Car();
            //    car.name = "BMW";
            //    Console.WriteLine("Price of the {0} is {1} :", car.name, car.price());
            //    Console.ReadLine();

            //  GeeksforGeeks g = new GeeksforGeeks()
            //  g.readers("Kirti", "C#");


            //Encapsulation obj = new Encapsulation();
            //obj.Name = "Ashwini";
            //obj.Age = 25;
            //Console.WriteLine(" Name : " + obj.Name);
            //Console.WriteLine(" Age : " + obj.Age);
            //Console.ReadLine();


            //Shape sh = new Square(4);
            //double result = sh.area();
            //Console.Write("{0}", result);
            //Console.ReadLine();


            //Overloading add = new Overloading();
            //add Add(4,5);
            //add Add(6.7f,7.4f);
            //add Add(7,6.7f,7.4f);
            //add Add(6.7f,5,7.4f);


            Animal animal = new Animal();
            animal.Run();
            animal = new Lion();
            animal.Run();
        }
    }
}
        
    