using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

namespace C_VariableTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, atadi, cinsiyyet, unvan, mw, dovr, accrej;

            mw = ""; dovr = ""; accrej = "";

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


            if (yash > 65)
            {
                dovr = "qocaliq";
            }
            else if (yash > 35)
            {
                dovr = "orta yash dovru";
            }
            else if (yash > 18)
            {
                dovr = "genclik";
            }
            else if (yash > 16)
            {
                dovr = "erken genclik";
            }
            else if (yash > 11)
            {
                dovr = "yeniyetmelik";
            }
            else if (11 < yash)
            {
                dovr = "ushaqliq";
            }
            
            
            
            if (dovr == "genclik")
            {
                accrej = "qeyde alinmishdir";
            }
           else
            {
                accrej = "qeyde alinmamishdir";
            }

            Console.Write("Unvanı daxil edin:");
            unvan = Console.ReadLine();




            Console.WriteLine("Siz " + soyad + " " + ad + " " + atadi + " " + mw + " " + dogumtarix + " -ci ilde dogulduğunuz ücün hal-hazırda " + yash + " yasınız vardır. Azerbaycan qanunvericiliyine uygun olaraq " + dovr + " dovrunuzu yasamaqdasınız. Bu is yerine sadece genclik döneminde olan sexsler muraciet ede bilerler. Bu telebi nezere alaraq sizin müracietiniz " + accrej + ".");
            


        }
    }
} 
        
