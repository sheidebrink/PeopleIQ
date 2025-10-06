using System.ComponentModel.DataAnnotations;

namespace PeopleIQ.Models;

public class AllocationMonth
{
    public int Id { get; set; }
    
    [Required]
    public int Month { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    public bool IsActive { get; set; } = true;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Navigation properties
    public ICollection<Allocation> Allocations { get; set; } = new List<Allocation>();
}