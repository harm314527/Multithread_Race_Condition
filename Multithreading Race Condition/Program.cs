using System;
using System.Threading;

namespace Multithreading_Race_Condition
{
    class Program
    {
        static Counter counter;
        static void Main(string[] args)
        {
            while (true)
            {
                 string input = Console.ReadLine();
                if (input == "Start")
                {
                    for (int i = 0; i < 40; i++)
                    {
                        int value = 0;

                        counter = new Counter(value);
                        Thread thread1 = new Thread(() => runup());

                        Thread thread2 = new Thread(() => rundown());

                        thread1.Start();
                        thread2.Start();
                        
                        try
                        {

                            thread1.Join();
                            thread2.Join();

                            Console.WriteLine("Result is " + counter.Value);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                }
            }
        }

        static public void runup()
        {
            for (int i = 0; i < 100000; i++)
            {
                counter.CountUp();
                
            }
            
        }
        static public void rundown()
        {
            for (int i = 0; i < 100000; i++)
            {
                counter.Countdown();
                
            }
        }
    }
}
