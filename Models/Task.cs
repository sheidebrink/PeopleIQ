using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleIQ.Models;

public class Task
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;
    
    [StringLength(2000)]
    public string? Description { get; set; }
    
    public TaskStatus Status { get; set; } = TaskStatus.ToDo;
    
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    
    public DateTime? DueDate { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? CompletedDate { get; set; }
    
    [Range(0, 100)]
    public int Progress { get; set; } = 0;
    
    [Range(1, 40)]
    public int? EstimatedHours { get; set; }
    
    [Range(0, 1000)]
    public int? ActualHours { get; set; }
    
    // Foreign Keys
    public int ProjectId { get; set; }
    public int? AssignedToId { get; set; }
    public int CreatedById { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    
    // Navigation properties
    public Project Project { get; set; } = null!;
    public User? AssignedTo { get; set; }
    public User CreatedBy { get; set; } = null!;
}

public enum TaskStatus
{
    ToDo,
    InProgress,
    InReview,
    Completed,
    Blocked
}

public enum TaskPriority
{
    Low,
    Medium,
    High,
    Critical
}