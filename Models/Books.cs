namespace kiretfinalexam.Models
{
    public class Books
    {
        public int BooksID { get; set; }
        public string name { get; set; }
       
        public DateTime Date { get; set; }
       public String type { get; set; }

        public string publisher { get; set; }

        public string language { get; set; }

        public int NumberOfPages { get; set; }

        public int isbn10 { get; set; }

        public int isbn13 { get; set; }

        public string weight { get; set; }
        public string dimensions { get; set; }
        public string rank { get; set; }

        public double review { get; set; }
        


        public List<Author> Authors { get; } = new();

        public ICollection<Information> Informations { get; set; } = new List<Information>();

    }
}
