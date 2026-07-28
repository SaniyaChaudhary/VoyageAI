using System;
using System.Collections.Generic;
using System.Text;

namespace VoyageAI.Domain.Entities;

public class Trip
{
    public Guid Id { get; set; }

    public string Destination { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Budget { get; set; }

    public List<Activity> Activities { get; set; } = [];
}