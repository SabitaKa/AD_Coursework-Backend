﻿namespace AD_Coursework.DTOs.Announcement
{
    public class AnnouncementDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
