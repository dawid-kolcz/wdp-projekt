using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int choice = 0;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("1. Class example.");
                Console.WriteLine("2. Dictionary example.");
                Console.WriteLine("3. Interface example.");
                Console.WriteLine("4. List & SortedList example.");
                Console.WriteLine("5. Queue example.");
                Console.WriteLine("6. Stack example.");
                Console.WriteLine("7. Exception example.");
                Console.WriteLine("8. Passing example.");
                Console.WriteLine("9. Exit.");

                Console.WriteLine("Choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException e) { }
                switch (choice)
                {
                    case 1: ClassExample(); break;
                    case 2: DictionaryExample(); break;
                    case 3: InterfaceExample(); break;
                    case 4: ListsExample(); break;
                    case 5: QueueExample(); break;
                    case 6: StackExample(); break;
                    case 7: ExceptionExample(); break;
                    case 8: PassingExample(); break;
                    case 9: exit = true; break;
                    default:; break;
                }
            }
        }

        private static void ClassExample()
        {
            Truck truck = new Truck();
            Console.WriteLine("Truck has {0} wheels!", truck.numberOfWheels);
        }

        private static void DictionaryExample()
        {
            Dictionary<string, string> books = new Dictionary<string, string>();
            books.Add("0000000000001", "Book 1");
            books.Add("0000000000002", "Book 2");
            books.Add("0000000000003", "Book 3");
            books.Add("0000000000004", "Book 4");
            books.Add("0000000000005", "Book 5");
            books.Add("0000000000006", "Book 6");

            Console.WriteLine(books["0000000000001"]);
            Console.WriteLine(books["0000000000002"]);
            Console.WriteLine(books["0000000000003"]);
            Console.WriteLine(books["0000000000004"]);
            Console.WriteLine(books["0000000000005"]);
            Console.WriteLine(books["0000000000006"]);
            try
            {
                Console.WriteLine(books["0000000000007"]);
            }catch(KeyNotFoundException e)
            {
                Console.WriteLine("No such book.");
                Console.WriteLine(e.Message);
            }


        }

        private static void InterfaceExample()
        {
            Strategy strat = new SimpleStrategy();
            strat.WriteStrategy();
            strat = new ComplexStrategy();
            strat.WriteStrategy();
        }

        private static void ListsExample()
        {
            Student s1 = new Student("C", "A");
            Student s2 = new Student("B", "B");
            Student s3 = new Student("A", "C");
            Student s4 = new Student("D", "D");

            List<Student> unsortedList = new List<Student> { s1, s2, s3, s4 };
            foreach (Student s in unsortedList)
            {
                Console.WriteLine("{0} {1}", s.name, s.lastname);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add(s1.name, s1);
            sortedList.Add(s2.name, s2);
            sortedList.Add(s3.name, s3);
            sortedList.Add(s4.name, s4);

            for (int i = 0; i < sortedList.Count; ++i)
            {
                Student s = (Student)sortedList.GetByIndex(i);
                Console.WriteLine("{0} {1}", sortedList.GetKey(i), s.lastname);
            }

        }

        private static void QueueExample()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("1. Do first item on the list");
            q.Enqueue("2. Do second item on the list");
            q.Enqueue("3. Do third item on the list");

            while(q.Count > 0)
            {
                string s = q.Dequeue();
                Console.WriteLine("Count of items in queue:{0} Poped: {1}", q.Count, s);
            }

        }

        private static void StackExample()
        {
            Random rand = new Random();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; ++i)
            {
                int r = rand.Next(10);
                stack.Push(r);
                Console.WriteLine("Pushing {0} on stack.", r);
            }

            while(stack.Count > 0)
            {
                Console.WriteLine("Poping {0}", stack.Pop());
            }
        }

        private static void ExceptionExample()
        {
            try
            {
                ExceptionMethod();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ExceptionMethod()
        {
            throw new NotImplementedException();
        }

        private static void PassingExample()
        {
            int number = 10;
            Console.WriteLine("Start: {0}", number);
            PassByValue(number);
            Console.WriteLine("By value: {0}", number);
            PassByReference(ref number);
            Console.WriteLine("By reference: {0}", number);
        }

        private static void PassByValue(int number)
        {
            number++;
        }

        private static void PassByReference(ref int number)
        {
            number++;
        }
    }
}
