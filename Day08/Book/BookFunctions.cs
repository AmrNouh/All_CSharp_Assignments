

// user Defined Delegate

// Built in Delegate

public class BookFunctions
{
    public static string GetTitle(Book B)
    {
        return $"Title : {B.Title}\n" ?? "";
    }
    public static string GetAuthors(Book B)
    {
        string authors = "";
        int number = 1;
        foreach (var item in B.Authors)
        {
            authors += $"Author{number++} Name :{item}\n";
        } ; 
        return authors;
    }
    public static string GetPrice(Book B)
    {
        return $"Book Price : {B.Price}\n";
    }
}
