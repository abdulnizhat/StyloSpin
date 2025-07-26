using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string RoleDisplayName { get; set; } = null!;

    public DateTime RolesCreationTime { get; set; }

    public long? RolesCreatorUserId { get; set; }

    public long? RolesDeleterUserId { get; set; }

    public DateTime? RolesDeletionTime { get; set; }

    public bool RolesIsDefault { get; set; }

    public bool RolesIsDeleted { get; set; }

    public DateTime? RolesLastModificationTime { get; set; }

    public int? RolesLastModifierUserId { get; set; }

    public string? RolesDescription { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
