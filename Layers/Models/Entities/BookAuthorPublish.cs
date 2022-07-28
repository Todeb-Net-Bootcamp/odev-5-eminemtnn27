using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class BookAuthorPublish
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ReaderId")]
        public Reader Reader  { get; set; }

        [ForeignKey("BookId")]
        public Book Book  { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author  { get; set; }

    }
}
