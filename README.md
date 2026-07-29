# VoyageAI 

AI-powered travel planner built with modern .NET technologies.

## Overview

VoyageAI is an intelligent travel planning application that helps users create personalised trips using AI recommendations, destination information, weather data, and travel insights.

## Tech Stack

### Backend
- ASP.NET Core (.NET 10)
- Entity Framework Core
- PostgreSQL
- ASP.NET Core Identity
- JWT Authentication
- OAuth 2.0

### AI Integration
- Google Gemini API
- Custom AI service abstraction using Clean Architecture

### Frontend
- React
- TypeScript
- Vite

### Other Technologies
- Redis
- Docker
- Azure
- GitHub Actions

## Planned Features

- User registration and login
- Google and Microsoft OAuth login
- Trip management
- AI-generated itineraries
- Destination recommendations
- Weather-based suggestions
- Budget planning
- AI travel assistant

## Architecture

The project follows Clean Architecture:

VoyageAI
│
├── VoyageAI.Api
├── VoyageAI.Application
├── VoyageAI.Domain
└── VoyageAI.Infrastructure


### AI Architecture

The AI integration follows a service abstraction approach:

IAIService
│
└── GeminiAIService
        │
        └── Google Gemini API


This allows the AI provider to be replaced in the future without changing the core application logic.

## Status

Currently under development