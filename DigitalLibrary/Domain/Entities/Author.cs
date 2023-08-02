﻿namespace Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Book> WrittenBooks { get; set; }
        public string PhotoUrl { get; set; }
    }
}