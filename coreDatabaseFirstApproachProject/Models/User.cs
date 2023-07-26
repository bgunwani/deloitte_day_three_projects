using System;
using System.Collections.Generic;

namespace coreDatabaseFirstApproachProject.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }
}
