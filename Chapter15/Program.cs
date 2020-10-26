using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight;
            string line;

            while (true)
            {
                Console.Write("身長(cm)：");
                line = Console.ReadLine();

                if (double.TryParse(line, out height))
                    break;
                    Console.WriteLine("正しい値を入力してください");
            }
            while (true)
            {
                Console.Write("体重(cm)：");
                line = Console.ReadLine();

                if (double.TryParse(line, out weight))
                    break;
                Console.WriteLine("正しい値を入力してください");
            }


            double bmi = (new BmiCalculator()).GetBmi(height,weight);
            Console.WriteLine($"BMIは{bmi:F1}です");
            

            #region
            //try
            //{

            //    var total = 1000;
            //    var line = Console.ReadLine();
            //    var count = int.Parse(line);
            //    var ans = total / count;
            //    Console.WriteLine(ans);
            //    Console.WriteLine("正常終了");
            //}catch (Exception ex)
            //{
            //    Console.WriteLine($"Type:{ex.GetType().Name}");
            //    Console.WriteLine($"Message:{ex.Message}");
            //    Console.WriteLine($"TargetSite:{ex.TargetSite}");
            //    Console.WriteLine($"StackTrace:{ex.StackTrace}");
            //}
            #endregion

        }
    }
}
