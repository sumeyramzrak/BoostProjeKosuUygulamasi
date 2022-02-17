using System;

namespace BoostProjeKosuUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validation;
            int step=0, stepCount=0, hour=0, minute=0;
            bool again = true;          
            do
            {
                Console.Clear();
                Console.Write("Merhaba :)");
                do
                {
                    Console.Write("\nCm Cinsinden Ortalama Adım Boyunuz:");
                    var x = Console.ReadLine();
                    validation = Validation(x);
                    if (validation) step = Convert.ToInt32(x);
                }
                while (!validation);

                do
                {
                    Console.Write("1 Dakikada Ortalama Kaç Adım Atıyorsunuz:");
                    var x = Console.ReadLine();
                    validation = Validation(x);
                    if (validation) stepCount = Convert.ToInt32(x);
                }
                while (!validation);

                do
                {
                    Console.Write("Koşu Süresi(Saat):");
                    var x = Console.ReadLine();
                    validation = Validation(x);
                    if (validation) hour = Convert.ToInt32(x);
                }
                while (!validation);

                do
                {
                    Console.Write("Koşu Süresi(Dakika):");
                    var x = Console.ReadLine();
                    validation = Validation(x);
                    if (validation) minute = Convert.ToInt32(x);
                    if (minute > 60)
                    {
                        validation = false;
                        Console.WriteLine("Dakida Değerini 0-60 Arasında Bir Değer Girin\n");
                    }
                }
                while (!validation);

                int totalDistance = CalculateDistance(step, stepCount, hour, minute);
                int totalStepCount = CalculateStep(stepCount, hour, minute);
                Console.Clear();
                Console.WriteLine($"Toplam Adım Sayınız:{totalStepCount} adım");
                Console.WriteLine($"Toplam Koşu Mesafeniz:{totalDistance / 100} metre");

                Console.WriteLine("------------------------------------------------------");
                Console.Write("\nTekrar Denemek İster Misiniz?------>");
                string answer = Console.ReadLine();
                if (answer == "E" && answer == "e" && answer == "Evet" && answer == "EVET" && answer == "evet")
                {
                    again = true;
                }

            } while (again);

            Console.ReadLine();

            }

        public static int CalculateDistance(int step,int stepCount,int hour,int minute)
        {
            int minuteDistance = step * stepCount;
            int totalDistance = minuteDistance * (hour * 60) + minuteDistance * minute;
            int target = stepCount * (hour * 60) + stepCount * minute;
            return totalDistance;
        }
        public static int CalculateStep(int stepCount,int hour,int minute)
        {
            int totalStepCount = stepCount * (hour * 60) + stepCount * minute;
            return totalStepCount;
        }

        public static bool Validation(string value)
        {
        
            bool validation = int.TryParse(value, out int number);               
            if (!validation)          
            {                              
                Console.WriteLine("Girilen Değer Geçersiz. Tekrar Deneyin");
            }

            else 
            {
                if (value == "0")
                {
                    Console.WriteLine("Sıfırdan Farklı Bir Değer Girin");
                }
                if (Convert.ToInt32(value) < 0)
                {
                    Console.WriteLine("Pozitif Bir Değer Girin");
                }
            }

            return validation;
        }


          
    }

  
}
