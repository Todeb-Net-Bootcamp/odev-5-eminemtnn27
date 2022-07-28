using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public ICollection<BookAuthorPublish> bookAuthorPublishes { get; set; }

    }
}
