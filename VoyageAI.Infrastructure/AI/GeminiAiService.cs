using VoyageAI.Application.Interfaces;

namespace VoyageAI.Infrastructure.AI;

public class GeminiAiService : IAIService
{
    public async Task<string> GenerateResponseAsync(string prompt)
    {
        return "AI generated travel plan placeholder";
    }
}