namespace ExaminationSystem
{
    [Flags]
    internal enum MultibleChooseAnswer : short
    {
        a = 1,
        b = 2,
        c = 4,
        d = 8,
        e = 16,
        f = 32,
        AllOfTheAbove = 64,
        NoneOfTheAbove = 128,

    }
}
