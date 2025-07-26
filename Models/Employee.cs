using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmployeeFullName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int DesignationId { get; set; }

    public int RoleId { get; set; }

    public int JobTitleId { get; set; }

    public DateOnly DateOfJoining { get; set; }

    public string ContactNumber { get; set; } = null!;

    public string? AlternateContactNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly Dob { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public string? PersonalEmailId { get; set; }

    public string? OfficialEmailId { get; set; }

    public string? Status { get; set; }

    public DateTime EmployeeCreationTime { get; set; }

    public long? EmployeeCreatorUserId { get; set; }

    public bool EmployeeIsDeleted { get; set; }

    public long? EmployeeDeleterUserId { get; set; }

    public DateTime? EmployeeDeletionTime { get; set; }

    public bool EmployeeIsDefault { get; set; }

    public DateTime? EmployeeLastModificationTime { get; set; }

    public int? EmployeeLastModifierUserId { get; set; }

    public string? Description { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Designation Designation { get; set; } = null!;

    public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; } = new List<EmployeeContact>();

    public virtual JobTitle JobTitle { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
