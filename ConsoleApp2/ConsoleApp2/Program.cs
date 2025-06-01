using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz1();
            Quiz2();
            Quiz3();
            CompareToFindMaxValue a = new CompareToFindMaxValue();
            a.Quiz5();
        }

        public class Order
        {
            private int orderNumber;
            private int totalNumber;

            public int OrderNumber
            {
                get
                {
                    return orderNumber;
                }
                set
                {
                    if (value >= 0)
                    {
                        orderNumber = value;
                        Console.WriteLine("정상적으로 값을 반환하였습니다.");
                    }
                    else
                    {
                        Console.WriteLine("값을 넣어주세요");
                    }
                }
            }
            public int TotalNumber
            {
                get
                {
                    return totalNumber;
                }
                set
                {
                    if (value >= 0)
                    {
                        totalNumber = value;
                        Console.WriteLine("정상적으로 값을 반환하였습니다.");
                    }
                    else
                    {
                        Console.WriteLine("값을 넣어주세요");
                    }
                }
            }
            public Order(int orderNumber, int totalNumber)
            {
                OrderNumber = orderNumber;
                TotalNumber = totalNumber;
            }
        }
        public class Animal
        {
            // 가상 메서드
            //virtual 키워드로 적힌 함수들은
            // 자식 클래스들이 재정의할수있다.
            public virtual string Makesound()
            {
                return "동물 소리";
            }
        }

        public class Dog : Animal
        {
            public override string Makesound()
            {
                return "멍멍";
            }
        }

        public class Cat : Animal
        {
            public override string Makesound()
            {
                return "야옹";
            }
        }

        class QuizManager
        {
            public void Food(string food)
            {
                switch (food)
                {
                    case "hamberger": Console.WriteLine(10);
                        break;
                    case "pizza": Console.WriteLine(12);
                        break;
                    case "noddle": Console.WriteLine(8);
                        break;
                    default: Console.WriteLine("해당 음식을 찾을 수 없습니다.");
                        break;
                }
            }
        }

        public class QuizManager1
        {
            public void Start()
            {
                        
            }
        }

        public static class ArrayUtils
        {
            public static void CheckArrayValueHaveBiggerThan100(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 100)
                    {
                        array[i] = 0;
                    }
                }
            }


            public static void FindMaxValue()
            {

            }
        }


        static void Quiz1()
        {
            Order order = new Order(100, 2000);
        }

        static void Quiz2()
        {
            Animal[] animals = new Animal[2];

            Dog dog = new Dog();
            Cat cat = new Cat();

            animals[0] = cat;
            animals[1] = dog;

            for (int i = -0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Makesound());
            }
        }

        static void Quiz3()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;

                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }

        static void Quiz4()
        {

        }

        public class CompareToFindMaxValue
        {
            public void Quiz5()
            {
                int num1 = 10;
                int num2 = 90;
                int num3 = 50;

                int max = num1;

                if (num1 > max)
                {
                    max = num1;
                }

                if (num2 > max)
                {
                    max = num2;
                }

                if (num3 > max)
                {
                    max = num3;
                }

                Console.WriteLine("가장 큰 값은 : " + max);
            }
        }
    }
}
