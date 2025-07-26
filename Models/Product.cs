using System;
using System.Collections.Generic;

namespace POsWebAPITesting.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductCategory { get; set; }

    public string? ProductImagePath { get; set; }

    public byte[]? ProductImageData { get; set; }

    public decimal? ProductPrice { get; set; }

    public bool? IsActive { get; set; }

    public string? Status { get; set; }

    public string? ExtraField1 { get; set; }

    public string? ExtraField2 { get; set; }

    public string? ExtraField3 { get; set; }
}
