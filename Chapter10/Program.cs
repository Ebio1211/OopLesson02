using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 省略可能な引数
            var person = new Person();
            //var person = new Person()
            //{
            //    FirstName = "鰈",
            //    LastName = "綿内"
            //};
            Console.WriteLine(person.FullName);
            #endregion
            #region オブジェクトを返すサンプル   
            //var book1 = MakeBookObject();
            //var book2 = MakeBookObject();
            //book1.Print();
            //book2.Print();
            #endregion
            #region GetArrayの呼び出し
            //var nums = GetArray(5);
            //
            ////配列内の要素の合計を求める
            //var total = 0;
            //
            //foreach (var num in nums)
            //{
            //    total += num;
            //}
            //
            //Console.WriteLine($"合計：{total}");
            #endregion

        }
        //指定された要素数分の値を入力して格納
        public static int[] GetArray(int count)
        {
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();
                array[i] = int.Parse(line);
            }
            return array; //配列を返却
        }

        //オブジェクトを返却するメソッド
        public static Book MakeBookObject()
        {
            Console.Write("書籍名　⇒ ");
            var title = Console.ReadLine();
            Console.Write("著者名　⇒ ");
            var author = Console.ReadLine();
            Console.Write("ページ数　⇒ ");
            var pagers =  Console.ReadLine();
            Console.Write("評価(1-5)　⇒ ");
            var rating = Console.ReadLine();



            //オブジェクト初期化子を使ったオブジェクトの初期化
            var book = new Book
            {
                Title = title,
                Author = author,
                Pages = int.Parse(pagers),
                Rating = int.Parse(rating)
            };
            return book;
        }
    }
}
