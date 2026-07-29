using System;
using System.Collections.Generic;
using System.Text;

namespace VoyageAI.Application.DTOs;

    public class TripResponseDto
    {
    public string Destination { get; set; } = string.Empty;

    public int DurationDays { get; set; }

    public decimal EstimatedCost { get; set; }

    public List<string> Itinerary { get; set; } = [];

    public List<string> TravelTips { get; set; } = [];

}

