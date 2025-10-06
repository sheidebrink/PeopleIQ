using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleIQ.Models;

public class Project
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(1000)]
    public string? Description { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public ProjectStatus Status { get; set; } = ProjectStatus.Planning;
    
    public ProjectPriority Priority { get; set; } = ProjectPriority.Medium;
    
    [Range(0, 100)]
    public int Progress { get; set; } = 0;
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal? Budget { get; set; }
    
    public int Sort { get; set; } = 0;
    
    public int? DepartmentId { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? UpdatedAt { get; set; }
    
    // Navigation properties
    public Department? Department { get; set; }
    public ICollection<ProjectMember> Members { get; set; } = new List<ProjectMember>();
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}

public enum ProjectStatus
{
    Planning,
    InProgress,
    OnHold,
    Completed,
    Cancelled
}

public enum ProjectPriority
{
    Low,
    Medium,
    High,
    Critical
}