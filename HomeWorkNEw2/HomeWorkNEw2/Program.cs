using System;

namespace HomeWorkNEw2
{
    class Program
    {

        #region Task 1


        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Arrayinize Nece Eded Daxildir");
        //    int.TryParse(Console.ReadLine(), out int size);
        //    int[] arr = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {


        //        int.TryParse(Console.ReadLine(), out arr[i]);
        //    }


        //    Array(arr);

        //}

        //static void  Array(int[] arr)
        //{

        //    int temp = 0;
        //    for (int j = 0; j <= arr.Length - 2; j++)
        //    {
        //        for (int i = 0; i <= arr.Length - 2; i++)
        //        {
        //            if (arr[i] > arr[i + 1])
        //            {
        //                temp = arr[i + 1];
        //                arr[i + 1] = arr[i];
        //                arr[i] = temp;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Sorted:");
        //    foreach (var p in arr)
        //        Console.WriteLine(p + " ");


        //}
        #endregion

        #region Task 2

        static void Main(string[] args) 
        {
            Console.WriteLine("String Sayin Daxil Edin");
            int.TryParse(Console.ReadLine(), out int size);
            
           
            
            string[] arr = new string[size];
            
            bool sorgu = false;
            
                
            for (int i = 0; i < size; i++)
            {
                if (0 < size)
                {
                  arr[i] = Convert.ToString(Console.ReadLine());
                }
                
            }
            
            Console.WriteLine("Hansi Herifi Axtarirsiniz");
            char.TryParse(Console.ReadLine(), out char a);
            array(arr, a);
            
                      
        }
        static void array(string[] arr , char a)
        {
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == a)
                    {
                        Console.WriteLine(item);
                        break;
                    }

                }
            }


        }

        


        #endregion





    }



}

