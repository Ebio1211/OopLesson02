// ■リスト11-12：nullキーワードを利用する
class Program
{
    static void Main()
    {
        var book = GetBook();
        if (book == null)  // nullかどうかでGetBookが成功したかどうかを判断
        {
            Console.WriteLine("Bookオブジェクトは生成できませんでした");
        }
        else
        {
            Console.WriteLine($"{book.Title}  {book.Author}");
        }
    }

    private static Book GetBook()
    {
        var line = Console.ReadLine();
        var items = line.Split(',');  // Splitメソッドについてはp.254参照
        if (items.Length != 2)
        {
            return null;  // 入力したデータが正しくない場合はnullを返す
        }
        var book = new Book
        {
            Title = items[0],
            Author = items[1],
        };
        return book;
    }
}
