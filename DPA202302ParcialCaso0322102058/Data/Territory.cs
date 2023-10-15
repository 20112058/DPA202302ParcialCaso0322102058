using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0322102058.Data;

public partial class Territory
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string Area { get; set; } = null!;

    public int Population { get; set; }
}
