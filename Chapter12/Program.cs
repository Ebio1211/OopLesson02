using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = new List<int> { 4, 6, 7, 1, 3, 9, 2, 5, 8 };
            ////メソッド構文
            //var num = nums.Count();
            //Console.WriteLine(num);

            //クエリ構文（糖衣構文…シンタックスシュガー）
            //var query = from num in nums
            //             where num % 2 == 0
            //             select num;

            //foreach (var num in query)
            //{
            //    Console.WriteLine(num);
            //}





            var books = new List<Book>();

            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));

            //ページ平均
            var page = books.Average(x=>x.Pages);
            //著者一覧(遅延実行、即時実行)
            var Authors = books.Select(x => x.Author).Distinct().ToArray();
            
            foreach (var author in Authors)
            {
                Console.WriteLine($"作者：{author}");
            }
            Console.WriteLine($"平均：{page}ページ");

            #region　リストの復習
            //var lines = new List<string>
            //{
            //    "おはよう",
            //    "こんにちは",
            //    "こんばんは"
            //};
            ////追加
            //lines.Add("おやすみ");
            //lines.Add("さようなら");

            ////削除
            //lines.RemoveAt(3);

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Clear(); //要素の全削除
            //Console.WriteLine($"リストの要素数は{lines.Count}です。");
            #endregion 
        }
    }
}
