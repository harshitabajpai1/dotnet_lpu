using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment_7March_Repository_Pattern.Models
{
    public class Book
    {
        //        Properties
        //Property    Type
        //BookId  int
        //Title   string
        //Author  string
        //Price   decimal

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Assuming BookId is not auto-generated
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
