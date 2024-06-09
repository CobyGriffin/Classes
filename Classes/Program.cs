namespace Classes
{
    internal class Program
    {
        public class Book
        {
            // Fields
            private string title;
            private string author;
            private int year;

            // Constructor
            public Book(string title, string author, int year)
            {
                this.title = title;
                this.author = author;
                this.year = year;
            }

            // Get and set methods
            public string GetTitle()
            {
                return title;
            }

            public void SetTitle(string title)
            {
                this.title = title;
            }

            public string GetAuthor()
            {
                return author;
            }

            public void SetAuthor(string author)
            {
                this.author = author;
            }

            public int GetYear()
            {
                return year;
            }

            public void SetYear(int year)
            {
                this.year = year;
            }

            // Method to display book information
            public void DisplayBookInfo()
            {
                Console.WriteLine($"Title: {title}, Author: {author}, Year: {year}");
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                Book[] books = new Book[10];
                int bookCount = 0;

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Add a New Book");
                    Console.WriteLine("2. Display All Books");
                    Console.WriteLine("3. Update a Book's Information");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    string? choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            if (bookCount < books.Length)
                            {
                                AddNewBook(books, ref bookCount);
                            }
                            else
                            {
                                Console.WriteLine("No more space to add new books.");
                            }
                            break;
                        case "2":
                            DisplayAllBooks(books, bookCount);
                            break;
                        case "3":
                            UpdateBookInformation(books, bookCount);
                            break;
                        case "4":
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine(); // Add an additional blank line for better readability
                }
            }

            static void AddNewBook(Book[] books, ref int bookCount)
            {
                Console.Write("Enter the title: ");
                string? title = Console.ReadLine();

                Console.Write("Enter the author: ");
                string? author = Console.ReadLine();

                Console.Write("Enter the year of publication: ");
                int year = int.Parse(Console.ReadLine());

                books[bookCount] = new Book(title, author, year);
                bookCount++;
                Console.WriteLine("Book added successfully.");
            }

            static void DisplayAllBooks(Book[] books, int bookCount)
            {
                for (int i = 0; i < bookCount; i++)
                {
                    books[i].DisplayBookInfo();
                }
            }

            static void UpdateBookInformation(Book[] books, int bookCount)
            {
                Console.Write("Enter the title of the book to update: ");
                string? titleToUpdate = Console.ReadLine();

                for (int i = 0; i < bookCount; i++)
                {
                    if (books[i].GetTitle().Equals(titleToUpdate, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter the new title: ");
                        string? newTitle = Console.ReadLine();

                        Console.Write("Enter the new author: ");
                        string? newAuthor = Console.ReadLine();

                        Console.Write("Enter the new year of publication: ");
                        int newYear = int.Parse(Console.ReadLine());

                        books[i].SetTitle(newTitle);
                        books[i].SetAuthor(newAuthor);
                        books[i].SetYear(newYear);
                        Console.WriteLine("Book information updated successfully.");
                        return;
                    }
                }

                Console.WriteLine("Book not found.");
            }
        }
    }
}
