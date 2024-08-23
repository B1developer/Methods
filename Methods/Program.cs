namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {
            //CALLING A METHOD
            PrintWelcomeMessage();

            //USING PARAMETERS IN METHODS
            PrintGreeting("Alice");
            PrintGreeting("Bob");
            PrintGreeting("Charlie");

            // RETURNING VALUES FROM METHODS
            int result = Addnumbers(5, 7);
            Console.WriteLine("The sum ist: " + result);

            // CHALLENGE: CALCULATE THE AREA OF A CIRCLE
            double area = CalculateAreaOfCircle(5);
            Console.WriteLine("The area of the circle is: " + area);
        }

        //CALLING A METHOD
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the C# tutorial series!");
        }


        //USING PARAMETERS IN METHODS
        public static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, " + name + "! Welcome to the C# tutorial series!");
        }


        // RETURNING VALUES FROM METHODS
        public static int Addnumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        // CHALLENGE: CALCULATE THE AREA OF A CIRCLE
        public static double CalculateAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }


    }





}