using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string number_of_pages { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }  
        public string bookPrice { get; set; }
        public ICollection<BookAuthorPublish> bookAuthorPublishes { get; set; }
    }
}
  