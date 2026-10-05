namespace MoviesAdmin.Models
{
    public class Movie
    {

        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Director { get; set; } = string.Empty;

        public DateOnly ReleaseDate { get; set; } // Date of release

        public string Genre { get; set; } = string.Empty;

        public string Synopsis { get; set; } = string.Empty;

        public string Rating { get; set; } = string.Empty; // e.g., PG-13, R, etc.

        public int Runtime { get; set; } // Duration in minutes

        public string Language { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string PersonalReview { get; set; } = string.Empty; // my personal review, if I've seen the movie. I plan to use mostly if not all movies I've seen.

    }
}
