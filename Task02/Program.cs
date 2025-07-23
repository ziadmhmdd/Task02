namespace Task02
{
    internal class Program
    {
        #region Task_2

        

        class Animal
        {
            // دي method محمية، ينفع تتشاف بس من الكلاسات اللي تورث منها
            protected void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        class Dog : Animal
        {
            public void MakeSound()
            {
                // هنا شغالة لأن Dog وارث من Animal
                Speak();
            }
        }

        // ------------------ Private Protected ------------------

        class Machine
        {
            // دي method private protected → تنفع تتشاف بس من كلاس وارث وفي نفس المشروع (assembly)
            private protected void Start()
            {
                Console.WriteLine("Machine is starting...");
            }
        }

        class Car : Machine
        {
            public void BeginStart()
            {
                // شغالة لأن Car وارث من Machine وفي نفس المشروع
                Start();
            }
        }

        // ------------------ Protected Internal ------------------

        class Document
        {
            // دي method protected internal → تتشاف من كلاس وارث أو من نفس المشروع حتى لو مش وارث
            protected internal void Print()
            {
                Console.WriteLine("Printing document...");
            }
        }

        class Report : Document
        {
            public void PrintReport()
            {
                // شغالة لأن Report وارث من Document
                Print();
            }
        }

        #endregion


        internal class Programs
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
                myDog.MakeSound(); // ✅ شغالة بسبب protected

                Car myCar = new Car();
                myCar.BeginStart(); // ✅ شغالة بسبب private protected

                Report myReport = new Report();
                myReport.PrintReport(); // ✅ شغالة بسبب protected internal

                // ولو عملت كده:
                Document doc = new Document();
                doc.Print(); // ✅ شغالة لأنها protected internal ودي نفس الـ assembly

                #endregion

                #region Polymorphism_Overloading_Run

                Console.WriteLine(Multiply(2, 3));              // 6
                Console.WriteLine(Multiply(2, 3, 4));           // 24
                Console.WriteLine(Multiply(2.5, 4.2));          // 10.5
                Console.WriteLine(Multiply(3, 2.5));            // 7.5
                Console.WriteLine(Multiply(2.5, 3));            // 7.5

                #endregion
            }
        }
        static void Main()
        {
           
        }
    }
}
