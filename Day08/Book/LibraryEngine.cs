

// user Defined Delegate

// Built in Delegate

public class LibraryEngine
{
    public static void ProcessBooks(List<Book> bList,userDefinedDelegate fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }
}
