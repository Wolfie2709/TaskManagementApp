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
        public DateTime? DueDate { get; set; } 
        public string Priority { get; set; }
        public DateTime CreatedAt { get; set; } 
        public int? TaskListID { get; set; }

        public bool HasNotified { get; set; } = false;
        public Category Category { get; set; }


    }
}
