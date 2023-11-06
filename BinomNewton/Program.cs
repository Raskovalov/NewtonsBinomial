namespace BinomNewton
{
    class BinomNewtons
    {   
        void binom(int colum)
        {
            int x = 1;
            List<int[]> arrays = new List<int[]>();

            //Формируем количество строк
            for(int i = 0; i < colum; i++) {
                arrays.Add(new int[x]);
                x++;
            }

            int y = -1;
            //Заполняем строки
            foreach(int[] array in arrays)
            {
                int maxIndex = array.Length - 1;
                array[maxIndex] = 1;
                array[0] = 1;

                if (maxIndex > 1)
                {
                    for(int i = 1; i < maxIndex; i++)
                    {
                        int number = arrays[y][i - 1];
                        array[i] = number + arrays[y][i];
                    }
                }

                y++;
            }

            foreach (int[] array in arrays)
            {
                string numm = " ";
                foreach (int a in array)
                {
                    numm += a.ToString() + " ";
                }
                Console.WriteLine(numm);
            }
        }

        static void Main()
        {
            Console.Write("Введите n/m: ");
            int colum = Convert.ToInt32(Console.ReadLine());

            BinomNewtons bin = new BinomNewtons();
            bin.binom(colum);

            Console.ReadLine();
        }
    }
}