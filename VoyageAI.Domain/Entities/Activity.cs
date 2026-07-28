using System;
using System.Collections.Generic;
using System.Text;

namespace VoyageAI.Domain.Entities;

public class Activity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public double Rating { get; set; }
}