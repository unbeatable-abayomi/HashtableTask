using System;
using System.Collections;

namespace HashtableTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            Result result1 = new Result(2019,89,"MATHS");
            Result result2 = new Result(2018, 99, "English");
            Result result3 = new Result(2019, 69, "Fine Art");
            Result result4 = new Result(2018, 69, "MATHS");
            Result result5 = new Result(2019, 29, "MATHS");
            Rankers rankers1 = new Rankers("mike",result1);
            Rankers rankers2 = new Rankers("Soj", result2);
            Rankers rankers3 = new Rankers("Adora", result3);
            Rankers rankers4 = new Rankers("Kenny", result4);
            Rankers rankers5 = new Rankers("Kunle", result5);
            rankers1.GetTopRanked();
            rankers2.GetTopRanked();
            rankers3.GetTopRanked();
            rankers4.GetTopRanked();
            rankers5.GetTopRanked();

           

            hashtable.Add(rankers1.Name, rankers1.GetResults());
            hashtable.Add(rankers2.Name, rankers2.GetResults());
            hashtable.Add(rankers3.Name, rankers3.GetResults());
            hashtable.Add(rankers4.Name, rankers4.GetResults());
            hashtable.Add(rankers5.Name, rankers5.GetResults());

           
            foreach (Object key in hashtable.Values)
            {
                Console.WriteLine($"{key}");
            }
        }
    }
}
