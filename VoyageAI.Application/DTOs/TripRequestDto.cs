using System;
using System.Collections.Generic;
using System.Text;

namespace VoyageAI.Application.DTOs;

public class TripRequestDto
{
    public string Destination { get; set; } = string.Empty;

    public int DurationDays { get; set; }

    public decimal Budget { get; set; }

    public List<string> Interests { get; set; } = [];
}