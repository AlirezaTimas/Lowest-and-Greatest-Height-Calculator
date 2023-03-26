namespace Studen_Heigh_App
{
    public class Program
    {

        static void Main(string[] args)
        {
            sen b = new sen();
            int z = 0;
            int k = 1;
            int min = 9999999;
            int max = -1;

            while (z <= 9)
            {
                Console.WriteLine("esme daneshjooye " + k + " ra vared konid");
                string esmeD = Console.ReadLine();
                Console.WriteLine("Ghade daneshjooye " + k + " ra vared konid");
                int ghad = int.Parse(Console.ReadLine());
                if (ghad < min)
                {
                    min = ghad;

                }
                else if (ghad > max)
                {
                    max = ghad;
                }
                b.insert(ghad, esmeD);
                Console.Clear();
                z++;
                k++;
            }
            Console.Clear();
            string Min = min.ToString();
            string Max = max.ToString();
            Console.WriteLine("Kootah ghad tarin: " + b.search(Min));
            Console.WriteLine("boland ghad tarin: " + b.search(Max));
            Console.ReadKey();



        }
        class sen
        {
            public string[,] a = new string[10, 2];
            public int p = 0;
            public int j;
            public void insert(int s, string b)
            {
                a[p, 0] = s.ToString();
                a[p, 1] = b;
                p++;
            }
            public string search(string s)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (a[i, 0] == s)
                    {
                        j = i;
                    }

                }
                return (a[j, 0] + " " + a[j, 1]);
            }

        }

    }

}



