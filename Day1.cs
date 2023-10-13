//namespace AdventCode2020
//{
//    internal class Day1
//    {
//        static void Main(string[] args)
//        {
//            string[] array = File.ReadAllLines("../../../adventofcode.com_2020_day_1_input.txt");

//            //--PART 1--
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    if (int.Parse(array[i])<=2020-FindSmallest(array))
//            //    {
//            //        for (int j = 0; j < array.Length; j++)
//            //        {
//            //            int total = int.Parse(array[i]) + int.Parse(array[j]);

//            //            if (total == 2020)
//            //            {
//            //                Console.WriteLine($"Found it! {array[i]} and {array[j]}\nThe sum is: {int.Parse(array[i])*int.Parse(array[j])}");
//            //                Console.ReadKey();
//            //            }

//            //        }
//            //    }
//            //}

//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = 0; j < array.Length; j++)
//                {
//                    for (int k = 0; k < array.Length; k++)
//                    {
//                        int total = int.Parse(array[i]) + int.Parse(array[j]) + int.Parse(array[k]);

//                        if (total == 2020)
//                        {
//                            Console.WriteLine($"Found it! {array[i]} and {array[j]} and {array[k]}\nThe multiplication is: {int.Parse(array[i]) * int.Parse(array[j]) * int.Parse(array[k])}");
//                            Console.ReadKey();
//                        }
//                    }

//                }

//            }

//        }


//        //--PART 1--
//        //static int FindSmallest(string[] array)
//        //{
//        //    int smallNum = int.Parse(array[0]);

//        //    for (int i = 0;i < array.Length;i++)
//        //    {
//        //        if(int.Parse(array[i]) < smallNum)
//        //        {
//        //            smallNum = int.Parse(array[i]);
//        //        }

//        //    }
//        //    return smallNum;
//        //}
//    }
//}