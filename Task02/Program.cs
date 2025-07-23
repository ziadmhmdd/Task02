namespace Task02
{
    #region Task_2

    //  Protected 

    class Animal
    {
        protected void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public void MakeSound()
        {
            Speak();
        }
    }

    // ------------------ Private Protected ------------------

    class Machine
    {
        private protected void Start()
        {
            Console.WriteLine("Machine is starting...");
        }
    }
    class Car : Machine
    {
        public void BeginStart()
        {
            Start();
        }
    }

    // ------------------ Protected Internal ------------------

    class Document
    {
        protected internal void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    class Report : Document
    {
        public void PrintReport()
        {
            Print();
        }
    }
    #endregion


    internal class Program
    {
        #region Polymorphism_Overloading_Examples

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(int a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, int b)
        {
            return a * b;
        }

        #endregion

        static void Main()
        {
            #region Task_2_RunExamples

            Dog myDog = new Dog();
            myDog.MakeSound();

            Car myCar = new Car();
            myCar.BeginStart();

            Report myReport = new Report();
            myReport.PrintReport();


            Document doc = new Document();
            doc.Print();

            #endregion
            #region Polymorphism_Overloading_Run

            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Multiply(2.5, 4.2));
            Console.WriteLine(Multiply(3, 2.5));
            Console.WriteLine(Multiply(2.5, 3));

            #endregion
        }
    }
}
