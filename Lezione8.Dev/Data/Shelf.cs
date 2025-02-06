namespace Lezione8.Dev.Data
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public List<Book>? Books { get; set; }
    }
}
