namespace CSharpConceptsMvcDemo.Models
{
    public static class CopyConstructorDemo
    {
        public class Book
        {
            public string Title;
            public string Author;

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }

            public Book(Book existingBook)
            {
                Title = existingBook.Title;
                Author = existingBook.Author;
            }
        }
    }
}
