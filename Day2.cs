namespace AdventCalEnv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min, validPassword = 0;
            string data;
            char key;
            string[] array = File.ReadAllLines("../../../adventofcode.com_2020_day_2_input.txt");

            //--PART 1--
            //for (int i = 0; i < array.Length; i++)
            //{
            //    string[] subs = array[i].Split('-', ' ', ':');
            //    min = int.Parse(subs[0]);
            //    max = int.Parse(subs[1]);
            //    key = Convert.ToChar(subs[2]);
            //    data = subs[4];
            //    int totalKey = CountLetters(data, key);
            //    if(totalKey >= min && totalKey <= max)
            //    {
            //        validPassword++;
            //    }
            //}

            for (int i = 0; i < array.Length; i++)
            {
                string[] subs = array[i].Split('-', ' ', ':');
                min = int.Parse(subs[0]);
                max = int.Parse(subs[1]);
                key = Convert.ToChar(subs[2]);
                data = subs[4];
                //check if the char at position min and max contains the key
                if (data[min] == key || data[max - 1] == key)
                {
                    validPassword++;
                }
            }


            Console.WriteLine(validPassword);
        }

        public static int CountLetters(string word, char countableLetter)
        {
            int count = 0;
            foreach (char c in word)
            {
                if (countableLetter == c)
                    count++;
            }
            return count;
        }
    }
}