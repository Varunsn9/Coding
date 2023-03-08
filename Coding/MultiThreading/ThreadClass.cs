using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Coding.MultiThreading
{
    public class ThreadClass
    {
        public void loop()
        {
            lock(this)
            {
            
                for(int i = 10; i >= 0; i--)
                {
                Console.WriteLine(i);
                Thread.Sleep(1000);

                }
            }
        }


        public static void aain(String[] args)
        {
            Thread t = Thread.CurrentThread;  
            t.Name= "MainThread";
            Console.WriteLine(t.Name);
            ThreadClass tc=new ThreadClass();
            Thread t1 = new Thread(new ThreadStart(tc.loop));
            Thread t2 = new Thread(new ThreadStart(tc.loop));
            Thread t3 = new Thread(new ThreadStart(tc.loop));

            t1.Start();
            Console.WriteLine("vadr");
            t2.Start();
            Console.WriteLine("ysud");
                t3.Start();

            try
            {
                t1.Abort();
                t2.Abort();
                t3.Abort();
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            string name = "varun";
            
            String name1 = "yusuf";
            Type ty=name.GetType();
            Type ty1 = name1.GetType();
            Console.WriteLine(ty);
            Console.WriteLine(ty1);
        }

    }

    public class MyThread
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    public class ThreadExample
    {
        public static void aain()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
