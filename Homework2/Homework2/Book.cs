namespace Task1;

internal class Book
{
    private string _author = "Unknow";
    private string _title = "Unknow";
    private int _page = 0;

    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrWhiteSpace(_author))
            {
                throw new ArgumentException();
            }
            _author = value;
        }
    }

    public string Title
    {
        get
        {
            return _title ;
        }
        set
        {
            _title = value;
        }
    }

    public int Page
    {
        get
        {
            return _page;
        }
        set
        {
            _page = value;
        }
    }

    public Book(string author, string title, int page)
    {
        Author = author;
        Title = title;
        Page = page;
    }

    public Book()
    {
    }

    public void GetDescription()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Кол-во страниц: {Page}");
    }
}