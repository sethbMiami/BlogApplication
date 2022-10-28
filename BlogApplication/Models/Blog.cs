using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }  
        public string Subheading { get; set; } 
        public string BlogContent { get; set; }  
        public DateTime CreatedDateTime { get; set; }
        public string BlogImage { get; set; }

        public Blog()
        {

        }
    }
}
