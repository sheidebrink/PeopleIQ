using Microsoft.EntityFrameworkCore;
using PeopleIQ.Models;

namespace PeopleIQ.Data;

public class PeopleIQContext : DbContext
{
    public PeopleIQContext(DbContextOptions<PeopleIQContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Expertise> Expertises { get; set; }
    public DbSet<Holiday> Holidays { get; set; }
    public DbSet<AllocationMonth> AllocationMonths { get; set; }
    public DbSet<Allocation> Allocations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Expertise configuration
        modelBuilder.Entity<Expertise>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            
            // Seed data
            entity.HasData(
                new Expertise { Id = 1, Name = "QA", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Expertise { Id = 2, Name = "Software", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Expertise { Id = 3, Name = "Data", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Expertise { Id = 4, Name = "Automation", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            );
        });

        // User configuration
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            
            entity.HasOne(u => u.Expertise)
                .WithMany(e => e.Users)
                .HasForeignKey(u => u.ExpertiseId)
                .OnDelete(DeleteBehavior.SetNull);
                
            // Seed data
            var createdAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            entity.HasData(
                // QA
                new User { Id = 1, FirstName = "Kim", LastName = "Smith", Email = "kim@peopleiq.com", ExpertiseId = 1, IsActive = true, CreatedAt = createdAt },
                
                // Software
                new User { Id = 2, FirstName = "David", LastName = "Johnson", Email = "david@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 3, FirstName = "George", LastName = "Williams", Email = "george@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 4, FirstName = "Steve", LastName = "Brown", Email = "steve@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 5, FirstName = "Isaac", LastName = "Davis", Email = "isaac@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 6, FirstName = "Josh", LastName = "Miller", Email = "josh@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 7, FirstName = "Blake", LastName = "Wilson", Email = "blake@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 8, FirstName = "Keegan", LastName = "Moore", Email = "keegan@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                new User { Id = 9, FirstName = "Bryce", LastName = "Taylor", Email = "bryce@peopleiq.com", ExpertiseId = 2, IsActive = true, CreatedAt = createdAt },
                
                // Automation
                new User { Id = 10, FirstName = "Jillian", LastName = "Anderson", Email = "jillian@peopleiq.com", ExpertiseId = 4, IsActive = true, CreatedAt = createdAt },
                new User { Id = 11, FirstName = "Chloe", LastName = "Thomas", Email = "chloe@peopleiq.com", ExpertiseId = 4, IsActive = true, CreatedAt = createdAt },
                
                // Data
                new User { Id = 12, FirstName = "Jeff", LastName = "Jackson", Email = "jeff@peopleiq.com", ExpertiseId = 3, IsActive = true, CreatedAt = createdAt },
                new User { Id = 13, FirstName = "Dan", LastName = "White", Email = "dan@peopleiq.com", ExpertiseId = 3, IsActive = true, CreatedAt = createdAt }
            );
        });

        // Department configuration
        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            
            // Seed data
            entity.HasData(
                new Department { Id = 1, Name = "Corporate", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 2, Name = "SISCO", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 3, Name = "Captives", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 4, Name = "Transportation", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 5, Name = "Benefits", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 6, Name = "BCC", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 7, Name = "CBCS", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                new Department { Id = 8, Name = "Wellness", IsActive = true, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            );
        });

        // Project configuration
        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            entity.Property(e => e.Budget).HasPrecision(18, 2);
            
            entity.HasOne(p => p.Department)
                .WithMany(d => d.Projects)
                .HasForeignKey(p => p.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);
                
            // Seed data
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 12, 31);
            var createdAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            entity.HasData(
                // Corporate (DepartmentId = 1)
                new Project { Id = 1, Name = "Overhead", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 2, Name = "PTO", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 3, Name = "Info-capture", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 4, Name = "Janus / Iris / Engage Maintenance / Improvements", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 5, Name = "Employee Historical DB", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 6, Name = "Carrier / Wholesale Dashboard", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 7, Name = "Janus SSO", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 8, Name = "Janus Roles Power BI", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 9, Name = "Training", DepartmentId = 1, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Low, Progress = 0, CreatedAt = createdAt },
                
                // SISCO (DepartmentId = 2)
                new Project { Id = 10, Name = "Actuaria Drug Warranty Online Claims Submission", DepartmentId = 2, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 11, Name = "Verification Phase II", DepartmentId = 2, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 12, Name = "Map Field LuminX Phase II", DepartmentId = 2, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 13, Name = "Verification Eligibility Audit (AWS AI)", DepartmentId = 2, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 14, Name = "Bank Reconciliation Phase II", DepartmentId = 2, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                
                // Captives (DepartmentId = 3)
                new Project { Id = 15, Name = "Data Report Power BI vs C#", DepartmentId = 3, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                
                // Transportation (DepartmentId = 4)
                new Project { Id = 16, Name = "CSR24 Highway Project", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 17, Name = "Independent Contractor Score Card", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 18, Name = "VIN DB Backup Automation", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 19, Name = "Producer Top 10", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Low, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 20, Name = "Client Iris", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 21, Name = "Risk - Management Migration Dashboard", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 22, Name = "NSTD Direct / Backoffice Iris", DepartmentId = 4, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                
                // Benefits (DepartmentId = 5)
                new Project { Id = 23, Name = "Account Team Changes", DepartmentId = 5, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                
                // BCC (DepartmentId = 6)
                new Project { Id = 24, Name = "Carrier premium reporting updates", DepartmentId = 6, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                
                // CBCS (DepartmentId = 7)
                new Project { Id = 25, Name = "Escrow Invoices", DepartmentId = 7, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 26, Name = "Data Submission Page", DepartmentId = 7, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 27, Name = "Adjuster/Vetiv Evaluation", DepartmentId = 7, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 28, Name = "Critical Email Mining Phase II", DepartmentId = 7, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.High, Progress = 0, CreatedAt = createdAt },
                
                // Wellness (DepartmentId = 8)
                new Project { Id = 29, Name = "Summary Sheet Automation & Efficiencies", DepartmentId = 8, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 30, Name = "Wellness", DepartmentId = 8, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt },
                new Project { Id = 31, Name = "Engage360", DepartmentId = 8, StartDate = startDate, EndDate = endDate, Status = ProjectStatus.Planning, Priority = ProjectPriority.Medium, Progress = 0, CreatedAt = createdAt }
            );
        });

        // Task configuration
        modelBuilder.Entity<Models.Task>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            
            entity.HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(t => t.AssignedTo)
                .WithMany(u => u.AssignedTasks)
                .HasForeignKey(t => t.AssignedToId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(t => t.CreatedBy)
                .WithMany(u => u.CreatedTasks)
                .HasForeignKey(t => t.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // ProjectMember configuration
        modelBuilder.Entity<ProjectMember>(entity =>
        {
            entity.HasIndex(e => new { e.ProjectId, e.UserId }).IsUnique();
            entity.Property(e => e.JoinedAt).HasDefaultValueSql("datetime('now')");

            entity.HasOne(pm => pm.Project)
                .WithMany(p => p.Members)
                .HasForeignKey(pm => pm.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(pm => pm.User)
                .WithMany(u => u.ProjectMemberships)
                .HasForeignKey(pm => pm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Holiday configuration
        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            
            // Seed data
            var createdAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            entity.HasData(
                new Holiday { Id = 1, Name = "Thanksgiving", Date = new DateTime(2025, 11, 27), IsRecurring = true, IsActive = true, CreatedAt = createdAt },
                new Holiday { Id = 2, Name = "Thanksgiving", Date = new DateTime(2025, 11, 28), IsRecurring = true, IsActive = true, CreatedAt = createdAt },
                new Holiday { Id = 3, Name = "Christmas", Date = new DateTime(2025, 12, 25), IsRecurring = true, IsActive = true, CreatedAt = createdAt }
            );
        });

        // AllocationMonth configuration
        modelBuilder.Entity<AllocationMonth>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            entity.HasIndex(e => new { e.Month, e.Year }).IsUnique();
            
            // Seed data
            var createdAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            entity.HasData(
                new AllocationMonth { Id = 1, Month = 1, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 2, Month = 2, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 3, Month = 3, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 4, Month = 4, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 5, Month = 5, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 6, Month = 6, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 7, Month = 7, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 8, Month = 8, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 9, Month = 9, Year = 2025, IsActive = true, CreatedAt = createdAt },
                new AllocationMonth { Id = 10, Month = 10, Year = 2025, IsActive = true, CreatedAt = createdAt }
            );
        });

        // Allocation configuration
        modelBuilder.Entity<Allocation>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            entity.HasIndex(e => new { e.AllocationMonthId, e.ProjectId, e.UserId }).IsUnique();
            
            entity.HasOne(a => a.AllocationMonth)
                .WithMany(am => am.Allocations)
                .HasForeignKey(a => a.AllocationMonthId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasOne(a => a.Project)
                .WithMany()
                .HasForeignKey(a => a.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
                
            entity.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
                
            // Seed data
            var createdAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            entity.HasData(
                // Kim's October 2025 allocations
                new Allocation { Id = 1, AllocationMonthId = 10, ProjectId = 20, UserId = 1, Percentage = 15, CreatedAt = createdAt }, // Client Iris - October
                new Allocation { Id = 2, AllocationMonthId = 10, ProjectId = 26, UserId = 1, Percentage = 15, CreatedAt = createdAt }  // Data Submission Page - October
            );
        });
    }
}