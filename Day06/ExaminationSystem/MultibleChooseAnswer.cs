namespace ExaminationSystem
{
    [Flags]
    internal enum MultibleChooseAnswer:short
    {
        a = 0,
        b = 1,
        c = 2,
        d = 4,
        e = 8,
        f = 16,
        AllOfTheAbove=32,
        NoneOfTheAbove=64,
    }
}
