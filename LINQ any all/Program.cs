using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_any_all
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>()
            {
                new Student("Mika", 1997, "210/2016", 9),
                new Student("Pera", 1996, "132/2014", 7.8),
                new Student("Marko", 1995, "98/2013", 6.12),
                 new Student("Nikola", 1998, "106/2016", 8.80),
                 new Student("Sara", 1995, "301/2013", 9.7),
                 new Student("Sanja", 1994, "489/2013",7.00),
                 new Student("Milos", 1998, "68/2016", 10),
                 new Student("Nemanja", 1994, "155/2013", 8.6),
                 new Student("Zika", 1998, "55/2016", 6.70),
                new Student("Uros", 1998, "158/2016", 9.50),
            };
            //-------------------------------------------------------------------
            var studentIme = from s in stud                                   //|
                             where s.Ime == "Milos"                           //|
                             select s;                                        //|
            var broj = stud.Where(s => s.Ime == "Milos").Count();             //| --koliko ima milosa 
            Console.WriteLine("Broj studenata sa takvim imenom je: " + broj); //|
            //-------------------------------------------------------------------

            //-------------------------------------------------------------
            bool any = studentIme.Any(s => s.Ime == "Uros");            //|--uporedjuje imena
            if (any)                                                    //|
                Console.WriteLine("Identicna imena");                   //|
            else Console.WriteLine("Razlicita imena");                  //|
            //-------------------------------------------------------------

            //-------------------------------------------------------------------
            bool anyIme = stud.Any(s => s.Ime == "Milos");                    //|--pretrazuje citavu list ,,STUD" u i trazi ime Milos 
            if (anyIme)                                                       //|
                Console.WriteLine("Neko od studenata se zove Milos");         //|
            else Console.WriteLine("Nijedan student se ne zove Milos");       //|
            //-------------------------------------------------------------------

            //---------------------------------------------------------------------------
            bool allIme = stud.All(s => s.Ime == "Nemanja");                           //|
                 anyIme = stud.Any(s => s.Ime == "Nemanja");                           //|
            if (allIme)                                                                //|---ALL
                Console.WriteLine("Svi studenti se zovu Nemanja");                     //|
            else if (anyIme) Console.WriteLine("Neko od studenata se zove Nemanja");   //|---ANY
            else Console.WriteLine("Ni jedan student se ne zove Milos");               //|
            //---------------------------------------------------------------------------
        }
    }
}
