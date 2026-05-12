public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Mock data - co najmniej 5 pozycji
        var books = new List<Book>
        {
            new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", Year = 1937, Publisher = "George Allen & Unwin" },
            new Book { Id = 2, Title = "1984", Author = "George Orwell", Genre = "Dystopia", Year = 1949, Publisher = "Secker & Warburg" },
            new Book { Id = 3, Title = "The Witcher", Author = "Andrzej Sapkowski", Genre = "Fantasy", Year = 1990, Publisher = "SuperNowa" },
            new Book { Id = 4, Title = "Solaris", Author = "Stanisław Lem", Genre = "Sci-Fi", Year = 1961, Publisher = "MON" },
            new Book { Id = 5, Title = "Dune", Author = "Frank Herbert", Genre = "Sci-Fi", Year = 1965, Publisher = "Chilton Books" }
        };

        BooksGrid.ItemsSource = books;
    }

    private void AddNewBook_Click(object sender, RoutedEventArgs e)
    {
        var addWin = new AddBookWindow();
        addWin.Owner = this;
        addWin.ShowDialog();
    }
}
