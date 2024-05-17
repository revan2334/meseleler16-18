namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task16
            //int n = int.Parse(Console.ReadLine());
            //int[] mas = new int[n];
            //int max = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"mas[{i}]=");
            //    mas[i] = int.Parse(Console.ReadLine());

            //    if (mas[i] % 2 == 0 && mas[i] > max)
            //    {

            //        max = mas[i];

            //    }


            //}
            //Console.WriteLine(max);
            #endregion
            #region task17
            //int n = int.Parse(Console.ReadLine());
            //int[] mas = new int[n];
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = int.Parse(Console.ReadLine());

            //}
            //int max = 0;
            //int min = 0;
            //for (int i = 1; i < mas.Length; i++)
            //{
            //    if (mas[i] > mas[max])
            //        max = i;
            //    if (mas[i] < mas[min])
            //        min = i;
            //}
            //int p = mas[max];
            //mas[max] = mas[min];
            //mas[min] = p;
            //for(int i = 0;i < mas.Length; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}
            #endregion
            #region task18
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            double s = 0;
            double p = 0;

            for (int i = 0; i < n; i++)
            {
                mas[i]=int.Parse(Console.ReadLine());
                if (mas[i] != 0)
                {
                    s = s + mas[i];

                }
                else;
                {
                    s = s + 0;
                    p = s;
                    
                }
            }
            Console.WriteLine(p);
            
            #endregion





        }

    }
}