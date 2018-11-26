using System;

namespace L04
{
    class Program
    {

        public class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;

            public override string ToString()
            {
                return "Person:" + FirstName + LastName + Age;
            }

        }
        static void Main(string[] args)
        {
            Person[] personList = new Person[5];
            personList[0] = new Person { FirstName = "Beyza ", LastName = "Altintas ", Age = 25 };
            personList[1] = new Person { FirstName = "Özlem ", LastName = "Altintas ", Age = 45 };
            personList[2] = new Person { FirstName = "Hasan ", LastName = "Altintas ", Age = 52 };
            personList[3] = new Person { FirstName = "Ayca ", LastName = "Altintas ", Age = 11 };
            personList[4] = new Person { FirstName = "Arda ", LastName = "Altintas ", Age = 9 };

                for (int i = 0; i < personList.Length; i++)
                {
                    if (personList[i].Age > 20)
                    Console.WriteLine(personList[i].FirstName + personList[i].LastName + personList[i].Age);
                }
        }
    }
}
