// ■リスト14-8：派生クラスを利用する
var pet1 = new FoodiePet("エイミー");
pet1.Play();
pet1.Eat();
pet1.Sleep();
Console.WriteLine($"{pet1.Name} 機嫌:{pet1.Mood} エネルギー:{pet1.Energy}");

var pet2 = new CheerfulPet("クー");
pet2.Play();
pet2.Eat();
pet2.Sleep();
Console.WriteLine($"{pet2.Name} 機嫌:{pet2.Mood} エネルギー:{pet2.Energy}");

var pet3 = new SleepyPet("ライアン");
pet3.Play();
pet3.Eat();
pet3.Sleep();
Console.WriteLine($"{pet3.Name} 機嫌:{pet3.Mood} エネルギー:{pet3.Energy}");
