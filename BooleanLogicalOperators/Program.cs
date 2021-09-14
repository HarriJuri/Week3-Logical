using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kasutajatunnus
            //programm küsib kasutajalt sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunnus
            //kui ka parool on õiged
            //kui mõlemad, kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus või parool on vale siis
            //programm kuvab "sisselogimine ebaõnnestus. prrovi uuesti."
            //kt: admin, pr:admin1234

            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string userpassword = Console.ReadLine();

            if(userName != "admin" || userpassword != "admin1234")
            {
                Console.WriteLine("Sisselogimine ebaõnnestus.Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }



        }
    }
}
