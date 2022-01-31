

// user Defined Delegate

// Built in Delegate

public class LibraryEngineBuiltIn
{
    public static void ProcessBooks(List<Book> bList, Func<Book,string> fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }
}
