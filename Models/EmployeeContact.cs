using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class EmployeeContact
{
    public int EmployeeContactId { get; set; }

    public int EmployeeId { get; set; }

    public int CountryId { get; set; }

    public int StateId { get; set; }

    public int CityId { get; set; }

    public string? Address { get; set; }

    public string? PostalCode { get; set; }

    public string? EmergencyContactName { get; set; }

    public string? EmergencyContactPhone { get; set; }

    public DateTime EmployeeContactsCreationTime { get; set; }

    public long? EmployeeContactsCreatorUserId { get; set; }

    public long? EmployeeContactsDeleterUserId { get; set; }

    public DateTime? EmployeeContactsDeletionTime { get; set; }

    public bool EmployeeContactsIsDeleted { get; set; }

    public DateTime? EmployeeContactsLastModificationTime { get; set; }

    public int? EmployeeContactsLastModifierUserId { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual State State { get; set; } = null!;
}
