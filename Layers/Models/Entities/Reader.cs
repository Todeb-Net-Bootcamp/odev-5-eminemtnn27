using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Reader
    {
        [Key]
        public int ReaderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
       // public ICollection<BookAuthorPublish> bookAuthorPublishes { get; set; }
    }
     
}