﻿namespace StudyToolWebApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public string Description { get; set; }
        public bool Saved { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }
        public Deck Deck { get; set;}
        public ICollection<CardCategory> Categorys { get; set; }
    }
}
