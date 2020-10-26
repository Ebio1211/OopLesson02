// ■リスト14-7：派生クラスの定義（FoodiePet/CheerfulPet/SleepyPetの各クラス）
class FoodiePet : VirtualPet
{
    public FoodiePet(string name) : base(name)
    {
    }

    public override void Eat()  // overrideを使って上書き定義
    {
        Mood += 3;
        Energy += 5;
        Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
    }

    public override void Play()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy -= 10;
        Console.WriteLine("FoodiePet.Playメソッドが実行されました");
    }

    public override void Sleep()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy += 2;
        Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
    }
}

class CheerfulPet : VirtualPet
{
    public CheerfulPet(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Mood += 0;  // 値は変化しない
        Energy += 5;
        Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
    }

    public override void Play()
    {
        Mood += 3;
        Energy -= 10;
        Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
    }

    public override void Sleep()
    {
        Mood -= 1;
        Energy += 2;
        Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
    }
}

class SleepyPet : VirtualPet
{
    public SleepyPet(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Mood -= 1;
        Energy += 5;
        Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
    }

    public override void Play()
    {
        Mood -= 1;
        Energy -= 10;
        Console.WriteLine("SleepyPet.Playメソッドが実行されました");
    }

    public override void Sleep()
    {
        Mood += 2;
        Energy += 2;
        Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
    }
}
