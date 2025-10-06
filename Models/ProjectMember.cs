using System.ComponentModel.DataAnnotations;

namespace PeopleIQ.Models;

public class ProjectMember
{
    public int Id { get; set; }
    
    // Foreign Keys
    public int ProjectId { get; set; }
    public int UserId { get; set; }
    
    public ProjectRole Role { get; set; } = ProjectRole.Member;
    
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? LeftAt { get; set; }
    
    public bool IsActive { get; set; } = true;
    
    // Navigation properties
    public Project Project { get; set; } = null!;
    public User User { get; set; } = null!;
}

public enum ProjectRole
{
    Member,
    Lead,
    Manager,
    Owner
}