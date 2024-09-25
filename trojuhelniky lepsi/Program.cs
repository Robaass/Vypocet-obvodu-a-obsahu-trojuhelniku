namespace trojuhelniky_lepsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pokracovat = false;
            while (pokracovat = true)
            {
                try
                {
                    Console.Write("zadejte délku první strany trojúhelníka (a), nebo stranu, na kterou je vedena výška (va): ");
                    float StranaA = float.Parse(Console.ReadLine());

                    Console.Write("zadejte délku druhé strany trojúhelníka (b): ");
                    float StranaB = float.Parse(Console.ReadLine());

                    Console.Write("zadejte délku třetí strany trojúhelníka (c)");
                    float StranaC = float.Parse(Console.ReadLine());

                    Console.Write("zadejte délku výšky (va) na první stranu trojúhelníka (a)");
                    float Vyska = float.Parse(Console.ReadLine());

                    if (StranaA == 0 || StranaB == 0 || StranaC == 0 || Vyska == 0)
                    {
                        Console.WriteLine("strany ani výška nesmií mít hodnotu 0");
                        pokracovat = true;
                    }
                    if (StranaA > 0 && StranaB > 0 && StranaC > 0)
                    {
                        float obvod = StranaA + StranaB + StranaC;
                        Console.WriteLine("Obvod trojúhelníku je:" + obvod);
                    }
                    else
                    {
                        Console.WriteLine("obvod nelze spočítat, protože nejsou zadány všechny strany, nebo jsou zadány chybně");
                        pokracovat = true;
                    }
                    if (Vyska > 0)
                    {
                        float obsah = (StranaA * Vyska) / 2;
                        Console.WriteLine("Obsah trojúhelníka je: " + obsah);
                    }
                    else
                    {
                        if (StranaA > 0 && StranaB > 0 && StranaC > 0)
                        {
                            float s = (StranaA + StranaB + StranaC) / 2;
                            float obsah = (float)Math.Sqrt(s * (s - StranaA) * (s - StranaB) * (s - StranaC));
                            Console.WriteLine("Obsah trojúhelníka je: " + obsah);
                        }
                        else
                        {
                            Console.WriteLine("Obsah nelze spočítat, špatně nebo nedostatečně zadané hodnoty");
                            pokracovat = true;
                        }
                    }
                    if (StranaA > 0 && StranaB > 0 && StranaC > 0)
                    {
                        if (StranaA == StranaB && StranaA == StranaC)
                        {
                            Console.WriteLine("trojúhelník je rovnostranný");
                        }
                        else
                        {
                            if (StranaA == StranaB || StranaB == StranaC || StranaC == StranaA)
                            {
                                Console.WriteLine("Trojúhelník je rovnoramenný");
                            }
                            else
                            {
                                Console.WriteLine("troúhelník je různostranný");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník nelze sestrojit");
                        pokracovat = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zadejte platné číslo");
                }
            }
        }
    }
}
