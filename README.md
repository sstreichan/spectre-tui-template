# Spectre TUI Template

A modern C# TUI (Terminal User Interface) application template built with Spectre.Console, featuring Native AOT compilation and automated versioning using Versionize.

## Features

- 🚀 **Spectre.Console** for rich terminal UI
- ⚡ **Native AOT** compilation for fast startup and small binaries
- 📦 **Automated Versioning** with Versionize (Conventional Commits)
- 🔄 **Automated Releases** via GitHub Actions
- 🤖 **Dependabot** integration for dependency updates

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Git

### Building

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run --project src/MyTuiApp
```

### Native AOT Build

```bash
# Build with Native AOT
dotnet publish -c Release

# The output will be in: src/MyTuiApp/bin/Release/net8.0/[runtime]/publish/
```

## Versioning

This project uses [Versionize](https://github.com/versionize/versionize) for automated versioning based on Conventional Commits.

### Commit Message Format

- `feat:` - New features (minor version bump)
- `fix:` - Bug fixes (patch version bump)
- `docs:` - Documentation changes
- `refactor:` - Code refactoring
- `perf:` - Performance improvements
- `chore:` - Maintenance tasks

### Creating a Release

Releases are automatically created when you push to `main` with conventional commits. The GitHub Actions workflow will:

1. Analyze commits since the last release
2. Update version numbers
3. Generate CHANGELOG
4. Create a Git tag
5. Create a GitHub release

## Project Structure

```
.
├── src/
│   └── MyTuiApp/          # Main application project
├── .github/
│   └── workflows/         # GitHub Actions workflows
├── .versionize           # Versionize configuration
└── README.md
```

## License

This template is available as open source.

## Contributing

Contributions are welcome! Please use conventional commits for all pull requests.
