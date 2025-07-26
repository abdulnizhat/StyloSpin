using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Designation
{
    public int DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string DesignationDisplayName { get; set; } = null!;

    public DateTime DesignationCreationTime { get; set; }

    public long? DesignationCreatorUserId { get; set; }

    public long? DesignationDeleterUserId { get; set; }

    public DateTime? DesignationDeletionTime { get; set; }

    public bool DesignationIsDefault { get; set; }

    public bool DesignationIsDeleted { get; set; }

    public DateTime? DesignationLastModificationTime { get; set; }

    public int? DesignationLastModifierUserId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
