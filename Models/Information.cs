namespace kiretfinalexam.Models
{
    public class Information
    {
        public int ID { get; set; }
        public int BooksID { get; set; }

        public string Name { get; set; }

        public string AName { get; set; }

        public int AuthorId { get; set; }

        public Books Book { get; set; }

        public Author Author { get; set; }
    }
}
