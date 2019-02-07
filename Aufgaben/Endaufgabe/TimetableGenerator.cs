using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Endaufgabe
{
    class TimetableGenerator
    {
        static List<Day> woche;
        static TimeSpan[] zeiten;
        static List<Course> kurse;
        static List<Prof> profs;
        static List<Room> raeume;
        static List<CourseOfStudy> studiengaenge;

        static void Main(string[] args)
        {
            LoadJsonRooms();
            foreach (Room raum in raeume)
            {
                Console.WriteLine(raum.Name);
                foreach (string a in raum.Ausstattung)
                    Console.WriteLine(a.ToString());                        // Ausgeben, sind Objekte korregt angelegt?
            }
            LoadJsonProfs();                                                // Die Daten werden geladen.
            foreach (Prof prof in profs)
            {
                Console.WriteLine(prof.name);
                foreach (TimeSpanDay t in prof.verhindert)
                    Console.WriteLine(t.tag.ToString());
            }

            LoadJsonCourseOfStudy();                                                // Die Daten werden geladen.
            foreach (CourseOfStudy cos in studiengaenge)
            {
                Console.WriteLine(cos.studiengangname);
            }

            LoadJsonCourses();                                                // Die Daten werden geladen.
            foreach (Course c in kurse)
            {
                Console.WriteLine(c.kursName);
            }

            Initializer();

            GenerateTimetable();
        }

        public static void Initializer()
        {
            woche = new List<Day>();
            woche.Add(new Day(DayEnum.Montag));
            woche.Add(new Day(DayEnum.Dienstag));
            woche.Add(new Day(DayEnum.Mittwoch));
            woche.Add(new Day(DayEnum.Donnerstag));
            woche.Add(new Day(DayEnum.Freitag));

            zeiten = new TimeSpan [6];
            zeiten[0] = new TimeSpan(new DateTime(2019, 01, 01, 7, 45, 0), new DateTime(2019, 01, 01, 9, 15, 0));
            zeiten[1] = new TimeSpan(new DateTime(2019, 01, 01, 9, 30, 0), new DateTime(2019, 01, 01, 11, 0, 0));
            zeiten[2] = new TimeSpan(new DateTime(2019, 01, 01, 11, 15, 0), new DateTime(2019, 01, 01, 12, 45, 0));
            zeiten[3] = new TimeSpan(new DateTime(2019, 01, 01, 14, 0, 0), new DateTime(2019, 01, 01, 15, 30, 0));
            zeiten[4] = new TimeSpan(new DateTime(2019, 01, 01, 15, 45, 0), new DateTime(2019, 01, 01, 17, 15, 0));
            zeiten[5] = new TimeSpan(new DateTime(2019, 01, 01, 17, 30, 0), new DateTime(2019, 01, 01, 19, 0, 0));

            foreach(Day tag in woche)
            {
                tag.bloecke = new List<Block>();
                for(int i = 0; i < zeiten.Length; i++)
                    tag.bloecke.Add(new Block(zeiten[i], i, tag.tag));
            }

            foreach (Course kurs in kurse) //lambdaausdrücke
            {
                kurs.prof = (Prof)profs.FirstOrDefault(prof => prof.kurse.Contains(kurs.kursName));
                kurs.studiengaenge = studiengaenge.Where(studiengang => studiengang.zuBesuchendeKurse.Contains(kurs.kursName)).ToList();
                kurs.anzahlStudenten = kurs.studiengaenge.Sum(studiengang => studiengang.anzahlStudenten);
                Console.WriteLine(kurs.kursName + ": " + kurs.anzahlStudenten + " Studenten, gehalten von: " + kurs.prof.name);
            }
        }

        public static void GenerateTimetable()
        {
            var _bloecke = woche.SelectMany(x => x.bloecke);

            foreach(Course kurs in kurse.OrderByDescending(kurs => kurs.anzahlStudenten).ToList())
            {
                kurs.room = raeume.OrderBy(raum => raum.Plaetze).FirstOrDefault(raum => 
                    raum.Plaetze >= kurs.anzahlStudenten 
                    && ListHelper.ContainsAllItems<string>(raum.Ausstattung, kurs.noetigeAusstattung));
                if(kurs.room != null)
                    Console.WriteLine(kurs.kursName + " in Raum: " + kurs.room.Name);
            }
        }

        public static void LoadJsonRooms()                                            // Räume laden
        {
            var data = File.ReadAllText("Room.json");                                 // Converter
            raeume = JsonConvert.DeserializeObject<List<Room>>(data);
        }

        public static void LoadJsonProfs()                                            // Profs laden
        {
            var data = File.ReadAllText("Prof.json");                                 // Converter zu einem c#-Objekt
            profs = JsonConvert.DeserializeObject<List<Prof>>(data);
        }

        public static void LoadJsonCourseOfStudy()                                   // Profs laden
        {
            var data = File.ReadAllText("CourseOfStudy.json");                       // Converter zu einem c#-Objekt
            studiengaenge = JsonConvert.DeserializeObject<List<CourseOfStudy>>(data);
        }

        public static void LoadJsonCourses()                                         // Profs laden
        {
            var data = File.ReadAllText("Course.json");                             // Converter zu einem c#-Objekt
            kurse = JsonConvert.DeserializeObject<List<Course>>(data);
        }
}

    public static class ListHelper
    {
        public static bool ContainsAllItems<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return !b.Except(a).Any();
        }
    }
}
