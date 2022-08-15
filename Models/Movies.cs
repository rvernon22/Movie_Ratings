namespace MovieRatings.Models
{
    public class Movies
    {
        public int Id { get; set; }

        public int TotalGrade { get; set; }

        public string MovieName { get; set; }
        public string Summary { get; set; }

        public int PlotGrade { get; set; }
        public string PlotDesc { get; set; }

        public int CineGrade { get; set; }
        public string CineDesc { get; set; }

        public int MusicGrade { get; set; }
        public string MusicDesc { get; set; }

        public int ActingGrade { get; set; }
        public string ActingDesc { get; set; }

        public int VFXGrade { get; set; }
        public string VFXDesc { get; set; }

        public Movies()
        {

        }
    }
}
