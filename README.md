# Spectre.Console TUI Template

[![Build and Publish](https://github.com/sstreichan/spectre-tui-template/actions/workflows/build-publish.yml/badge.svg)](https://github.com/sstreichan/spectre-tui-template/actions/workflows/build-publish.yml)
[![Release](https://github.com/sstreichan/spectre-tui-template/actions/workflows/release.yml/badge.svg)](https://github.com/sstreichan/spectre-tui-template/actions/workflows/release.yml)

A modern TUI (Terminal User Interface) application template using:

- **Spectre.Console** - Beautiful console UI framework
- **Native AOT** - Fast startup and small binaries
- **Versionize** - Automated semantic versioning
- **GitHub Actions** - Multi-platform builds (Linux, Windows, macOS including ARM64)

## Features

- ✨ Interactive terminal UI with Spectre.Console
- 🚀 Native AOT compilation for maximum performance
- 📦 Automated releases for multiple platforms
- 🔄 Conventional commits with automatic versioning
- 🎯 C# coding standards with .editorconfig
- 🤖 Dependabot for automated dependency updates

## Quick Start

### Prerequisites

- .NET 8.0 SDK or later
- Git

### Build & Run

```bash
# Clone the repository
git clone https://github.com/sstreichan/spectre-tui-template.git
cd spectre-tui-template

# Restore dependencies
dotnet restore

# Run the application
dotnet run --project src/MyTuiApp

# Try the hello command
dotnet run --project src/MyTuiApp -- hello YourName
dotnet run --project src/MyTuiApp -- hello YourName --fancy
```

### Build Native AOT

```bash
# Build for your platform
dotnet publish src/MyTuiApp/MyTuiApp.csproj -c Release -r linux-x64

# Run the native binary
./src/MyTuiApp/bin/Release/net8.0/linux-x64/publish/MyTuiApp
```

## Development

### Adding Commands

1. Create a new command class in `src/MyTuiApp/Commands/`
2. Inherit from `Command<TSettings>`
3. Register in `Program.cs`

Example:

```csharp
public class MyCommand : Command<MyCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandArgument(0, "<input>")]
        public string Input { get; init; } = string.Empty;
    }

    public override int Execute(CommandContext context, Settings settings)
    {
        AnsiConsole.MarkupLine($"Processing: [green]{settings.Input}[/]");
        return 0;
    }
}
```

### Commit Conventions

Use [Conventional Commits](https://www.conventionalcommits.org/) for automatic versioning:

- `feat:` - New features (bumps minor version)
- `fix:` - Bug fixes (bumps patch version)
- `perf:` - Performance improvements
- `docs:` - Documentation changes
- `refactor:` - Code refactoring
- `BREAKING CHANGE:` - Breaking changes (bumps major version)

Example:
```bash
git commit -m "feat: add interactive file selection menu"
git commit -m "fix: resolve crash on empty input"
```

## Automated Workflows

### Release Workflow

On push to `main`:
1. Versionize analyzes commits
2. Updates version and CHANGELOG.md
3. Creates git tag
4. Creates GitHub release

### Build Workflow

On new release:
1. Builds Native AOT binaries for:
   - Linux (x64)
   - Windows (x64)
   - macOS (x64, ARM64)
2. Uploads artifacts to release

## Project Structure

```
MyTuiApp/
├── .github/
│   ├── workflows/          # GitHub Actions
│   └── dependabot.yml     # Dependency automation
├── src/
│   └── MyTuiApp/
│       ├── Commands/       # CLI commands
│       ├── Models/         # Data models
│       ├── UI/            # UI components
│       └── Program.cs
├── .editorconfig          # Coding standards
├── .versionize            # Versioning config
├── Directory.Build.props  # MSBuild properties
└── README.md
```

## License

MIT
