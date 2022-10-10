namespace BlogApplication.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public Blog()
        {

        }
    }
}
