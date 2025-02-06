namespace Lezione8.Dev.Data
{
    public class Book
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public double Price { get; set; }
        public int ShelfId { get; set; }
        public Shelf? Shelf { get; set; }
    }
}
