using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string? Region { get; set; }

    public DateTime CountryCreationTime { get; set; }

    public long? CountryCreatorUserId { get; set; }

    public long? CountryDeleterUserId { get; set; }

    public DateTime? CountryDeletionTime { get; set; }

    public bool CountryIsDefault { get; set; }

    public bool CountryIsDeleted { get; set; }

    public DateTime? CountryLastModificationTime { get; set; }

    public int? CountryLastModifierUserId { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; } = new List<EmployeeContact>();

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
