# Spectre TUI Template

![GitHub release (latest by date)](https://img.shields.io/github/v/release/sstreichan/spectre-tui-template)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/sstreichan/spectre-tui-template/release.yml)

A modern C# TUI (Terminal User Interface) application template built with Spectre.Console, featuring Native AOT compilation and automated versioning using Versionize.

## Features

- 🚀 **Spectre.Console** for rich terminal UI
- ⚡ **Native AOT** compilation for fast startup and small binaries
- 📦 **Automated Versioning** with Versionize (Conventional Commits)
- 🔄 **Automated Releases** via GitHub Actions
- 🤖 **Dependabot** integration for dependency updates
- 🏷️ **Automated Changelogs** with every release

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
- `chore:` - Maintenance tasks (hidden in changelog)

### Creating a Release

Releases are automatically created when you push to `main` with conventional commits. The GitHub Actions workflow will:

1. Analyze commits since the last release
2. Update version numbers in project files
3. Generate CHANGELOG with categorized changes
4. Create a Git tag (e.g., v1.0.0)
5. Create a GitHub release with release notes
6. Attach compiled binaries as release assets

You can also manually trigger the release workflow from the Actions tab.

## Project Structure

```
.
├── src/
│   └── MyTuiApp/          # Main application project
├── .github/
│   └── workflows/         # GitHub Actions workflows
│       ├── release.yml    # Automated release workflow
│       └── build.yml      # CI build workflow
├── .versionize           # Versionize configuration
├── CHANGELOG.md          # Auto-generated changelog
└── README.md
```

## CI/CD Workflows

### Release Workflow
- **Trigger**: Push to `main` or manual dispatch
- **Actions**: Version bump, changelog generation, GitHub release creation

### Build Workflow
- **Trigger**: Push and Pull Requests
- **Actions**: Build verification, test execution, artifact creation

## License

This template is available as open source.

## Contributing

Contributions are welcome! Please use conventional commits for all pull requests.
