using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string DepartmentDisplayName { get; set; } = null!;

    public DateTime DepartmentCreationTime { get; set; }

    public long? DepartmentCreatorUserId { get; set; }

    public long? DepartmentDeleterUserId { get; set; }

    public DateTime? DepartmentDeletionTime { get; set; }

    public bool DepartmentIsDefault { get; set; }

    public bool DepartmentIsDeleted { get; set; }

    public DateTime? DepartmentLastModificationTime { get; set; }

    public int? DepartmentLastModifierUserId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Designation> Designations { get; set; } = new List<Designation>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
