using VoyageAI.Application.DTOs;
using VoyageAI.Application.Interfaces;

namespace VoyageAI.Application.Services;

public class TravelPlannerService : ITravelPlannerService
{
    public async Task<TripResponseDto> GeneratePlanAsync(TripRequestDto request)
    {
        return new TripResponseDto
        {
            Destination = request.Destination,
            DurationDays = request.DurationDays,
            EstimatedCost = request.Budget,
            Itinerary = new List<string>
            {
                "Explore local attractions",
                "Try local cuisine",
                "Visit cultural landmarks"
            },
            TravelTips = new List<string>
            {
                "Carry travel documents",
                "Check local weather before travelling"
            }
        };
    }
}