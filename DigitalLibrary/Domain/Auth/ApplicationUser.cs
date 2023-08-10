﻿using Domain.DataTransferObjects;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Book>? FavouriteBooks { get; set; }
        public string? Description { get; set; }
    }
}
