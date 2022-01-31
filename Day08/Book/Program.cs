userDefinedDelegate definedDelegate1 = BookFunctions.GetTitle;
userDefinedDelegate definedDelegate3 = BookFunctions.GetPrice;
userDefinedDelegate definedDelegate2 = BookFunctions.GetAuthors;

string[] authors = { "amr", "Mohamed", "Ali" };
Book book1 = new Book("ABC","Pla Pla", authors,new DateTime(1,1,1,2,0,0),20);
Book book2 = new Book("DEF","hhhhhh", authors,new DateTime(1,1,1,2,0,0),20);
Book book3 = new Book("GHI","aaaaaa", authors,new DateTime(1,1,1,2,0,0),20);
Book book4 = new Book("JKL","mmmmmmm", authors,new DateTime(1,1,1,2,0,0),20);
List<Book> books = new List<Book>();
books.Add(book1);
books.Add(book2);
books.Add(book3);
books.Add(book4);

// user Defined Delegate
LibraryEngine.ProcessBooks(books, definedDelegate1);

// Built in Delegate
LibraryEngineBuiltIn.ProcessBooks(books, BookFunctions.GetAuthors);

public delegate string userDefinedDelegate(Book book);
