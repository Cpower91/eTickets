﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string ImageURL { get; set; }
        public DateTime StarteDate { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }

}
