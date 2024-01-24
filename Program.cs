using System;
using System.Net.NetworkInformation;

namespace C_VariableTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, atadi, cinsiyyet, unvan, mw, dovr, accrej;


            Console.Write("Adinizi daxil edin:");
            ad = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin:");
            soyad = Console.ReadLine();
            Console.Write("Ata adinizi daxil edin:");
            atadi = Console.ReadLine();
            Console.Write("Cinsiyyeti daxil edin:");
            cinsiyyet = Console.ReadLine();


            if (cinsiyyet == "kishi")
            {
                mw = "oğlu";
            }
            else if (cinsiyyet == "gadin")
            {
                mw = "qızı";
            }


            Console.Write("Dogum tarixini daxil edin:");
            int dogumtarix = int.Parse(Console.ReadLine());
            int yash = DateTime.Now.Year - dogumtarix;


            if (yash < 11)
            {
                dovr = "uşaqlıq";
            }
            else if (11 < yash)
            {
                dovr = "yeniyetməlik";
            }
            else if (16 < yash)
            {
                dovr = "erkən gənclik";
            }
            else if (18 < yash)
            {
                dovr = "gənclik";
            }
            else if (35 < yash)
            {
                dovr = "erkən gənclik";
            }
            else if (65 < yash)
            {
                dovr = "qocalıq";
            }
            
            
            if (dovr == "gənclik")
            {
                accrej = "qeydə alınmışdır";
            }
            

            Console.Write("Unvanı daxil edin:");
            unvan = Console.ReadLine();




            Console.WriteLine("Siz" + soyad + ad + atadi + mw + dogumtarix + "doğulduğunuz üçün hal-hazırda" + yash + "yaşınız vardır. Azərbaycan qanunvericiliyinə uyğun olaraq" + dovr + "dövrünüzü yaşamaqdasınız. Bu iş yerinə sadəcə gənclik dönəmində olan şəxslər müraciət edə bilərlər. Bu tələbi nəzərə alaraq sizin müraciətiniz" + accrej + ".");
            Console.ReadLine();


        }
    }
} 
        
