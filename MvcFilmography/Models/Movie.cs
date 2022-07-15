namespace MvcFilmography.Models
{
    public class Movie
    {   
        public int Id { get; set; }
        public static int IdCounter { get; set; } = 0; // 这是为了方便给ID序列号
        public string Title { get; set; }
        public string Category { get; set; }
        public string Budget { get; set; }
        public DateTime Date { get; set; }

        public Movie(string title, string category, string budget, DateTime date)
        {
            Id = IdCounter++;
            Title = title;
            Category = category;
            Budget = budget;
            Date = date;
        }

    }
}
