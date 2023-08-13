﻿using Domain.Enums;

namespace Domain.Entities
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Description { get; set; }
        public string? CoverUrl { get; set; }
        public Author? Author { get; set; }
        public string TextId { get; set; }
        public List<BookTag>? BookTags { get; set; }
    }
}
