using System;
using System.Collections.Generic;
using System.Text;
using VoyageAI.Application.DTOs;

namespace VoyageAI.Application.Interfaces;
public interface ITravelPlannerService
{
    Task<TripResponseDto> GeneratePlanAsync(TripRequestDto request);
}
