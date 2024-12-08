# Adventure Game

An interactive text-based adventure game where players explore the magical realm of Eldoria. The game features dynamic storytelling that adapts to player choices.

## Features

- Interactive story with multiple paths
- Four options for each decision
- Dynamic storyline that changes based on previous choices
- Personality analysis based on player decisions
- Meaningful consequences to player choices

## How to Run

1. Open the solution in Visual Studio
2. Press F5 or click "Start Debugging" to run the game
3. Follow the on-screen prompts to play

## Game Structure

The game is organized into three main classes:
- `Program.cs`: Entry point and player name input
- `Game.cs`: Main game logic and story progression
- `Question.cs`: Handles question presentation and input validation

## Requirements

- .NET 8.0 or later
- Visual Studio 2022 or later (recommended)

## Development

To modify the game:
1. Each question in Game.cs can be customized
2. New story branches can be added by modifying the conditional logic
3. Additional personality traits can be added to the conclusion generator
