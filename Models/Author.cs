namespace kiretfinalexam.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AName { get; set; }
        public string description { get; set; }

        public List<Books> Book { get; } = new();
        public ICollection<Information> Informations { get; set; } = new List<Information>();

    }
}
