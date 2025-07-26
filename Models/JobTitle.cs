using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class JobTitle
{
    public int JobTitleId { get; set; }

    public string JobTitle1 { get; set; } = null!;

    public string JobTitleDisplayName { get; set; } = null!;

    public DateTime JobTitleCreationTime { get; set; }

    public long? JobTitleCreatorUserId { get; set; }

    public long? JobTitleDeleterUserId { get; set; }

    public DateTime? JobTitleDeletionTime { get; set; }

    public bool JobTitleIsDefault { get; set; }

    public bool JobTitleIsDeleted { get; set; }

    public DateTime? JobTitleLastModificationTime { get; set; }

    public int? JobTitleLastModifierUserId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
