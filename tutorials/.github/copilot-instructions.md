# Copilot Instructions for C# Tutorial Codebase

## Project Overview
This is a beginner-focused **C# learning and tutorial repository** for the "Introduction to C#" series. The project teaches foundational C# concepts through interactive examples, aligned with Microsoft Learn and the C# for Beginners video series.

## Directory Structure & Naming Conventions
- **Lernprogramme/**: German word meaning "Learning Programs" - contains all example code files
- Each file targets a specific tutorial lesson (e.g., `hello-world.cs`, `numbers-in-csharp.cs`)
- File names use kebab-case matching lesson titles from `README.md`
- All code examples are standalone, runnable C# programs

## Tutorial Progression Model
The repository follows a strict **sequential learning model** based on the README:
1. Hello world (string type basics)
2. Numbers in C# (numeric types, calculations)
3. Tuples and types (type definitions)
4. Branches and loops (control flow, conditionals, iteration)
5. List collection (collections, sequences)
6. Pattern matching (pattern-based logic)

**Key principle**: Each new lesson builds on concepts from previous ones. Avoid introducing advanced features before foundational lessons cover prerequisites.

## Code Examples Guidelines
- **Target audience**: Absolute beginners with no prior programming experience
- **Complexity**: Minimal, focused examples (the hello-world.cs is a model: single-line program)
- **Scope**: Each file demonstrates ONE core concept from its lesson
- **Runnable**: All examples must compile and execute with `dotnet run` or in interactive environments
- **Comments**: Add educational comments explaining the "why", not just "what"

## Adding New Tutorial Examples
1. Create new `.cs` file in `Lernprogramme/` with kebab-case name matching the lesson
2. Add high-level description to `README.md` linking to the corresponding Microsoft Learn lesson
3. Ensure the code example is:
   - Independently executable
   - Demonstrates the lesson's core concept
   - Uses only C# features taught in current and prior lessons
   - Includes brief, educational comments

## Integration Points
- Examples are designed to complement the [C# for Beginners video series](https://aka.ms/dotnet/beginnervideos/youtube/csharp)
- Links in README point to `learn.microsoft.com/dotnet/csharp/tour-of-csharp/tutorials/`
- Code examples can be run in browser environments (GitHub Codespaces, online editors) or locally
- Avoid language features that vary by platform; stick to core C# fundamentals

## Development Workflow
When adding new lessons:
1. Verify the concept isn't covered in prior lessons
2. Write the simplest possible `.cs` example demonstrating that concept
3. Test: ensure it compiles without errors
4. Document in README with a clear, concise description
5. Maintain the lesson ordering - don't reorder the tutorial sequence
