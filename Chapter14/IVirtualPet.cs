interface IVirtualPet
{
    string Name { get; }
    int Mood { get; set; }
    int Energy { get; set; }

    void Eat();
    void Play();
    void Sleep();
    void Rest();
}
