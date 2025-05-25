using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num  = new int[10] {1,2,3,4,5,6,7,8,9,10 };
            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] %2 ==0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            

            /* // 퀴즈3
            Order order1 = new Order(1000, 20000);*/

            /* 퀴즈2
            Quizmager quizmager = new Quizmager();
            quizmager.start();*/
            /* 델리게이트
            Tesk tesk = new Tesk();

            MyDelegate Del = new MyDelegate(tesk.AddTen);

            MyDelegate Del2 = tesk.AddTen;

            int result = Del2(10);
            Console.WriteLine(result); */

            /* 델리게이트
            Disk disk = new Disk();

            FuncDelegate cleanFunc = new FuncDelegate(disk.Clean);


            FuncDelegate cleanFunc22 = disk.Clean;
            cleanFunc22(3);*/
        }


        // public delegate int MyDelegate(int d);

        /* 델리게이트
        private delegate int FuncDelegate(int time);

        public class Disk
        {
            public int Clean(int n)
            {
                Console.WriteLine("작업 실행");
                return 0;
            }
        }*/

        /* 델리게이트
        public class Tesk
        {
            public int AddTen(int ten)
            {
                Console.WriteLine("출력 : ");
                return ten +10;
            }
        }*/

        /* 퀴즈2
        public class Animal
        {
            public virtual string MakeSound()
            {
                return "동물 소리";
            }

            public class Dog : Animal
            {
                public override string MakeSound()
                {
                    return "멍";
                }
            }

            public class Cat : Animal
            {
                public override string MakeSound()
                {
                    return "야옹";
                }
            }
        }
        public class Quizmager
        {
            public void start()
            {
                
            }
        }*/

        /* // 퀴즈3
        public class Order
        {
            private int ordernumber;
            private int totalamount;

            public int OrderNumber
            {
                get
                {
                    return ordernumber;
                }

                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("음수입니다");
                    }
                    else
                    { 
                        ordernumber = value;
                        Console.WriteLine("정상적으로 값을 반환하였습니다");
                    }
                }
            }

            public int TotalAmount
            {
                get { return totalamount; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("음수입니다");
                    }
                    else
                    {
                        ordernumber = value;
                        Console.WriteLine("정상적으로 값을 반환하였습니다");
                    }
                }
            }
            public Order(int ordernumber, int totalamount)
            {
                OrderNumber = ordernumber;
                TotalAmount = totalamount;
            }
        }*/
    }
}
