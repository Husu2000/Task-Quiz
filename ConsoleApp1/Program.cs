using System;

class Program
{
    static void Main(string[] args)
    {
        ImtahanHazirla();
    }

    static void ImtahanHazirla()
    {
        string[][] suallarCavablar = new string[10][]; 
        Random rand = new Random();

        
        suallarCavablar[0] = new string[] { "Hindistanın paytaxtı hansıdır?", "Bakı", "New Delhi", "Ankara" };
        suallarCavablar[1] = new string[] { "Türkiyənin ən yüksək dağı hansıdır?", "Ağrı Dağı", "Everest", "K2" };
        suallarCavablar[2] = new string[] { "Nəyə görə 'Cəmiyyət sazanda sənətin qoruyucusudur' ifadəsi çıxış edib?", "Türk", "Azərbaycan", "Rusiya" };
        suallarCavablar[3] = new string[] { "Dünyada ilk humanitar yardım təşkilatı hansıdır?", "Kızıl Xaç", "Qızıl Yarım Ay", "Dünya Sağlamlıq Təşkilatı" };
        suallarCavablar[4] = new string[] { "İlk yazı sistemini həyata keçirən mədəniyyət hansıdır?", "Sümer", "Mısır", "Roma" };
        suallarCavablar[5] = new string[] { "Titanik gemisinin batış tarixi hansıdır?", "1912", "1908", "1920" };
        suallarCavablar[6] = new string[] { "İlk kosmonavt kimdir?", "Yuri Gagarin", "Neil Armstrong", "Buzz Aldrin" };
        suallarCavablar[7] = new string[] { "Şah İsmayıl kimdir?", "Safavi şahı", "Osmanlı padişahı", "Möhtəlif sefir" };
        suallarCavablar[8] = new string[] { "Kasparov hansı idmanda məşhurdur?", "Şahmat", "Boks", "Futbol" };
        suallarCavablar[9] = new string[] { "Dünyanın ən uzun dəniz kənarı hansı ölkəyə aid edilir?", "Kanada", "Avstraliya", "Rusiya" };

        // Cavabları qarışdırmaq
        for (int i = 0; i < 10; i++)
        {
            Shuffle(rand, suallarCavablar[i], 1, 3);
        }

        int toplamXal = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(suallarCavablar[i][0]); 
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine($"{(char)('a' + j - 1)}) {suallarCavablar[i][j]}"); 
            }

            Console.Write("Cavabınızı daxil edin (a, b və ya c): ");
            char userCavab = Char.ToLower(Console.ReadKey().KeyChar); 
            Console.WriteLine();

            
            char dogruCavab = 'a';
            for (int j = 1; j <= 3; j++)
            {
                if (suallarCavablar[i][j] == "Bakı") 
                {
                    dogruCavab = (char)('a' + j - 1); 
                    break;
                }
            }

            
            if (userCavab == dogruCavab)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("Düzgün!");
                toplamXal += 10; 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Səhv!");
                toplamXal -= 10; 
                if (toplamXal < 0)
                {
                    toplamXal = 0; 
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        Console.WriteLine($"İmtahan bitmişdir. Siz {toplamXal} xal toplamısınız.");
    }

    
    static void Shuffle<T>(Random rand, T[] array, int startIndex, int endIndex)
    {
        for (int i = startIndex; i <= endIndex; i++)
        {
            int j = rand.Next(i, endIndex + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
