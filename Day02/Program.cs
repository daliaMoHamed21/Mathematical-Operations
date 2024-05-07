namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Task1 Calculate area of rectangle  **************");
            //Enter lenght and width of the rectangle
            Console.Write("Enter the length of the rectangle: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            //calc area
            double areaOfRec = lenght * width;

            Console.WriteLine($" Area of rectangle : {lenght} * {width} = {areaOfRec} ");

            Console.WriteLine("************** Task2 Calculate area of square  **************");
           
           //Enter side lenghtof the square 
            Console.Write("Enter the side length of the square: ");
            double sideLenght = double.Parse(Console.ReadLine());
            //calculate area 
            double area = sideLenght * sideLenght ;
            Console.WriteLine($"The area of square :{sideLenght} * {sideLenght} = {area} ");



            // print age 
            Console.WriteLine("************** Task3 Take and print age **************");
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age}");

            Console.WriteLine("************** Task4 print name and age **************");
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine($"Hello {userName}, your age is {userAge}.");




        }
    }
}