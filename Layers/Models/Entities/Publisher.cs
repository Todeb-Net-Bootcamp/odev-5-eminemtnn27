using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Publisher
    {
        [Key]
        public int PublisherId  { get; set; }
        [Required]
        public string Name  { get; set; }
        public string Address  { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Book> books { get; set; }
        public ICollection<BookAuthorPublish> bookAuthorPublishes { get; set; }


    }
}
