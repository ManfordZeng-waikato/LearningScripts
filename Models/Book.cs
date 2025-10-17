namespace LearningScripts.Models
{
    public class Book
    {
        //[FromQuery]
        public int? BookId { get; set; }

        public string? Author { get; set; }

        public Gender AuthorGender { get; set; }

        public DateTime? ReleaseDate { get; set; }



        public enum Gender
        {
            Male, Female, Other
        }
        public override string ToString()
        {
            return $"Book object - Book id:{BookId}, Author:{Author}";
        }
    }
}
