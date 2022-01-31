

// user Defined Delegate

// Built in Delegate

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicaationDate { get; set; }
    public decimal Price { get; set; }

    public Book(string iSBN, string title, string[] authors, DateTime publicaationDate, decimal price)
    {
        ISBN = iSBN;
        Title = title;
        Authors = authors;
        PublicaationDate = publicaationDate;
        Price = price;
    }

    public override string ToString()
    {
        return $"Book ISBN: {ISBN},\nBook Title: {Title}";
    }


}
