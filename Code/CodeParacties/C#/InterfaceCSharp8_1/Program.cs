namespace InterfaceCSharp8_1
{
    using System;
    namespace Csharp8Features
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Enter Day");
                string day = Console.ReadLine();

                var message = day.ToUpper() 
                    switch
                {
                    "SUNDAY" => Weekend(),
                    "SAT" => Weekend(), 
                    "MONDAY" => "start of the weekday",
                    "FRIDAY" => "end of the weekday",
                    _ => "Invalid day"
                };
                Console.WriteLine($"{day} is {message}");

                //Rectangle rectangle = new Rectangle { Length = 20, Height = 40 };
                //if(rectangle.Length==20)
                //{

                //}
                //var (length, height) = rectangle;
                //Console.WriteLine($"The rectangle Length: {length} and Height: {height}");
                //if (rectangle is (20, _) rect)
                //{
                //    Console.WriteLine("The rectangle has a length of 20");
                //}

            }

            private static string Weekend()
            {
                return "Weekend";
            }
        }

        public class Rectangle
        {
            public double Length { get; set; }
            public double Height { get; set; }

            public double Width { get; set; }
            public void Deconstruct( out double height, out double length)
            {
                length = Length;
                height = Height;
            }
            public void Deconstruct( out double length, out double height,out double width)
            {
                length = Length;
                height = Height;
                width = Width ;
            }
        }
    }
}