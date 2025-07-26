using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class City
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public string? CityCode { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PostalCode { get; set; }

    public string? Status { get; set; }

    public DateTime CitiesCreationTime { get; set; }

    public long? CitiesCreatorUserId { get; set; }

    public long? CitiesDeleterUserId { get; set; }

    public DateTime? CitiesDeletionTime { get; set; }

    public bool CitiesIsDefault { get; set; }

    public bool CitiesIsDeleted { get; set; }

    public DateTime? CitiesLastModificationTime { get; set; }

    public int? CitiesLastModifierUserId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; } = new List<EmployeeContact>();

    public virtual State? State { get; set; }
}
