using System;
using System.Collections.Generic;
using System.Text;

namespace VoyageAI.Application.Interfaces;
public interface IAIService
{
    Task<string> GenerateResponseAsync(string prompt);
}