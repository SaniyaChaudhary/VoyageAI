using Microsoft.AspNetCore.Mvc;
using VoyageAI.Application.DTOs;
using VoyageAI.Application.Interfaces;

namespace VoyageAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TripController : ControllerBase
{
    private readonly ITravelPlannerService _travelPlannerService;

    public TripController(ITravelPlannerService travelPlannerService)
    {
        _travelPlannerService = travelPlannerService;
    }

    [HttpPost]
    public async Task<ActionResult<TripResponseDto>> GeneratePlan(TripRequestDto request)
    {
        var response = await _travelPlannerService.GeneratePlanAsync(request);

        return Ok(response);
    }
}