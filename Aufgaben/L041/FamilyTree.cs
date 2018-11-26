using System;
using static System.Console;

namespace L041
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public DateTime NowYear;

        public Person Mom;
        public Person Dad;

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + DateOfBirth; // Von einem Objekt einen String zurückliefern.
        }
    }


    public class Familytree
    {
        public static Person Find(Person person)
        {
            if(DateTime.Now.Year - person.DateOfBirth.Year > 100 ) // Bei > 40 kommt Diana Spencer, 57 Jahre
                return person;

            Person ret = null;
            ret = Find(person.Mom);
            if (ret != null)
                return ret;
            ret = Find(person.Dad);
            return ret;
            // if (person.LastName != "Battenberg")
            //     return person;
            // ret = Find(person.Mom);
            //     if (ret != null)
            //     return ret;
            // ret = Find(person.Dad);
            //      return ret;
        }


        public static Person BuildTree()
        {
            return  
                new Person { FirstName = "36 Willi", LastName = "Cambridge", DateOfBirth=new DateTime(1982, 07, 21), //36
                    Mom = new Person { FirstName = "57 Diana", LastName = "Spencer", DateOfBirth = new DateTime(1961, 07, 01), // 57
                        Mom = new Person {FirstName = "82 Franzi", LastName="Roche", DateOfBirth = new DateTime(1936, 01, 20), // 82
                            Mom = new Person {FirstName = "110 Jahre Ruth", LastName="Gill", DateOfBirth = new DateTime(1908, 06, 07),}, // 110
                            Dad = new Person {FirstName = "133 Moritz", LastName="Roche", DateOfBirth = new DateTime(1885, 07, 08)} // 133
                        },
                        Dad = new Person {FirstName = "94 Eddie", LastName="Spencer", DateOfBirth = new DateTime(1924, 01, 24), // 94
                            Mom = new Person {FirstName = "121 Cynthia", LastName="Hamilton", DateOfBirth = new DateTime(1897, 08, 16)}, // 121
                            Dad = new Person {FirstName = "126 Albert", LastName="Spencer", DateOfBirth = new DateTime(1892, 05, 23)} // 126
                        },
                    },
                    Dad = new Person {FirstName = "70 Charlie", LastName = "Wales", DateOfBirth = new DateTime(1948, 11, 14), // 70
                        Mom = new Person {FirstName = "92 Else", LastName="Windsor", DateOfBirth = new DateTime(1926, 04, 21), // 92
                            Mom = new Person {FirstName = "118 Lisbeth", LastName="Bowes-Lyon", DateOfBirth = new DateTime(1900, 08, 04)}, // 118
                            Dad = new Person {FirstName = "123 Schorsch-Albert", LastName="York", DateOfBirth = new DateTime(1895, 12, 14)} // 123
                        },
                        Dad = new Person {FirstName = "97 Philip", LastName="Battenberg", DateOfBirth = new DateTime(1921, 06, 10), // 97
                            Mom = new Person {FirstName = "133 Alice", LastName="Battenberg", DateOfBirth = new DateTime(1885, 02, 25)}, // 133
                            Dad = new Person {FirstName = "136 Andi", LastName="ElGreco", DateOfBirth = new DateTime(1882, 02, 01)}, // 136
                        },
                    },
                };
        }
    }
}