using VoyageAI.Application.DTOs;
using VoyageAI.Application.Interfaces;

namespace VoyageAI.Application.Services;

public class TravelPlannerService : ITravelPlannerService
{
    private readonly IAIService _aiService;

    public TravelPlannerService(IAIService aiService)
    {
        _aiService = aiService;
    }

    public async Task<TripResponseDto> GeneratePlanAsync(TripRequestDto request)
    {
        var prompt = $"""
        Create a travel itinerary.

        Destination: {request.Destination}
        Duration: {request.DurationDays} days
        Budget: {request.Budget}
        Interests: {string.Join(", ", request.Interests)}
        """;

        var aiResponse = await _aiService.GenerateResponseAsync(prompt);

        return new TripResponseDto
        {
            Destination = request.Destination,
            DurationDays = request.DurationDays,
            EstimatedCost = request.Budget,
            Itinerary = new List<string>
            {
                aiResponse
            },
            TravelTips = new List<string>
            {
                "Check weather before travelling",
                "Keep travel documents ready"
            }
        };
    }
}