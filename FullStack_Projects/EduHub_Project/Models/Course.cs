﻿using System.ComponentModel.DataAnnotations;

namespace EduHub_Project.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public int UserId {  get; set; }
        public string? Category { get; set; }
        public string? Level { get; set; }
    }
}
