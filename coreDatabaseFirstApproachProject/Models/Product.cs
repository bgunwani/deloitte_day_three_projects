using System;
using System.Collections.Generic;

namespace coreDatabaseFirstApproachProject.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? Status { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
