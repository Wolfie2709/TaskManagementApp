using System;

namespace TaskManagementApp.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? DueDate { get; set; } // make nullable if optional
        public string Priority { get; set; }
        public DateTime CreatedAt { get; set; } // ✅ Add this
        public int? TaskListID { get; set; }
        public string AssigneeName { get; set; }
        public DateTime? AssignedDate { get; set; }
        public int Progress { get; set; }
        public string Tags { get; set; } 
        public string Comments { get; set; }
    }
}
