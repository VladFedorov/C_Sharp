using System;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        class WThread
        {
            Random random = new Random();
            int a;
            Thread wthread;

            public WThread(int num)
            {
                wthread = new Thread(this.write);
                wthread.Start(num);
            }

            void write(object num)
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\VUser\source\repos\C_Sharp\Lab6\Lab6\test.txt");
                Random random = new Random();
                for (int i = 0; i < (int)num; i++)
                {
                    writer.WriteLine(random.Next(1, 100));
                }
                writer.Close();
            }

            //public RThread(bool a)
            //{
            //    thread = new Thread(this.write);
            //    thread.Start(num);
            //}

        }
        class RThread
        {
            Random random = new Random();
            Thread rthread;
            public RThread(int num)
            {
                rthread = new Thread(this.read);
                rthread.Start(num);
            }

            void read(object num)
            {
                StreamReader reader = new StreamReader(@"C:\Users\VUser\source\repos\C_Sharp\Lab6\Lab6\test.txt");
                for (int i = 0; i < (int)num; i++)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                reader.Close();
            }
        }

        static void Main(string[] args)
        {
            WThread t1 = new WThread(9);
            RThread t2 = new RThread(9);

            Console.Read();

        }

    }
}