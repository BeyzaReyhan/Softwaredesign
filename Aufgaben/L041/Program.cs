using System;
using static System.Console;

namespace L041
{
    public class SimplePerson
    {
    public string FirstName;
    public string LastName;
    public DateTime DateOfBirth;
    public DateTime NowYear;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person root = Familytree.BuildTree();

            Person found = Familytree.Find(root);

            WriteLine(found);
        }
    }
}
