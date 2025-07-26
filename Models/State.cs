using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class State
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public string? StateCode { get; set; }

    public int? CountryId { get; set; }

    public string? Status { get; set; }

    public DateTime StateCreationTime { get; set; }

    public long? StateCreatorUserId { get; set; }

    public long? StateDeleterUserId { get; set; }

    public DateTime? StateDeletionTime { get; set; }

    public bool StateIsDefault { get; set; }

    public bool StateIsDeleted { get; set; }

    public DateTime? StateLastModificationTime { get; set; }

    public int? StateLastModifierUserId { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; } = new List<EmployeeContact>();
}
