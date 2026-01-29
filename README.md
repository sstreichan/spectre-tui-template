# Spectre TUI Template

![GitHub release (latest by date)](https://img.shields.io/github/v/release/sstreichan/spectre-tui-template)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/sstreichan/spectre-tui-template/release.yml)
![GitHub](https://img.shields.io/github/license/sstreichan/spectre-tui-template)

A modern C# TUI (Terminal User Interface) application template built with Spectre.Console, featuring Native AOT compilation and automated versioning using Versionize.

## Features

- 🚀 **Spectre.Console** for rich terminal UI
- ⚡ **Native AOT** compilation for fast startup and small binaries
- 📦 **Automated Versioning** with Versionize (Conventional Commits)
- 🔄 **Automated Releases** via GitHub Actions
- 🤖 **Dependabot** integration for dependency updates
- 🏷️ **Automated Changelogs** with every release
- ✨ **Auto-Rename Template** - Automatically renames project when using template

## Using This Template

### Quick Start

1. Click the **"Use this template"** button at the top of this repository
2. Enter your new repository name (e.g., `my-awesome-app`)
3. Create the repository
4. **That's it!** 🎉 

The template will automatically:
- ✅ Rename all `MyTuiApp` occurrences to your repository name
- ✅ Update all file names and directory names
- ✅ Update solution and project files
- ✅ Update README badges with your repository info
- ✅ Remove the template cleanup workflow

### What Gets Renamed

If you name your repository `my-cool-app`, the template will create:

| Convention | Example | Used In |
|------------|---------|----------|
| PascalCase | `MyCoolApp` | C# namespaces, class names, project files |
| kebab-case | `my-cool-app` | Repository name, URLs |
| snake_case | `my_cool_app` | Configuration files |
| lowercase  | `mycoolapp` | Package names |

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Git

### Building

```bash
# Clone your repository
git clone https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
cd YOUR_REPO_NAME

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run --project src/YOUR_PROJECT_NAME
```

### Native AOT Build

```bash
# Build with Native AOT
dotnet publish -c Release

# The output will be in: src/YOUR_PROJECT_NAME/bin/Release/net8.0/[runtime]/publish/
```

## Development

### Recommended IDE

- **Visual Studio 2022** (17.8 or later)
- **Visual Studio Code** with C# Dev Kit
- **JetBrains Rider** (2023.3 or later)

### Project Structure

```
.
├── src/
│   └── MyTuiApp/              # Main application project
│       ├── MyTuiApp.csproj     # Project file
│       └── Program.cs          # Application entry point
├── .github/
│   └── workflows/             # GitHub Actions workflows
│       ├── release.yml        # Automated release workflow
│       ├── build.yml          # CI build workflow
│       └── template-cleanup.yml # Template renaming (auto-removes)
├── .versionize               # Versionize configuration
├── Directory.Build.props     # Shared MSBuild properties
├── CHANGELOG.md              # Auto-generated changelog
├── MyTuiApp.sln              # Solution file
└── README.md
```

## Versioning & Releases

This project uses [Versionize](https://github.com/versionize/versionize) for automated versioning based on [Conventional Commits](https://www.conventionalcommits.org/).

### Commit Message Format

Use these prefixes for your commits:

| Prefix | Description | Version Bump | In Changelog |
|--------|-------------|--------------|-------------|
| `feat:` | New features | Minor (0.x.0) | ✅ |
| `fix:` | Bug fixes | Patch (0.0.x) | ✅ |
| `perf:` | Performance improvements | Patch | ✅ |
| `docs:` | Documentation changes | Patch | ✅ |
| `refactor:` | Code refactoring | Patch | ✅ |
| `chore:` | Maintenance tasks | - | ❌ (hidden) |
| `build:` | Build system changes | Patch | ❌ |

### Examples

```bash
# Feature (bumps minor version)
git commit -m "feat: add user authentication system"

# Bug fix (bumps patch version)
git commit -m "fix: resolve null reference exception in parser"

# Breaking change (bumps major version)
git commit -m "feat!: redesign configuration API

BREAKING CHANGE: Configuration now uses fluent API instead of JSON"
```

### Creating a Release

Releases are **automatically created** when you push to `main` with conventional commits:

1. Push commits to `main`
2. GitHub Actions runs the release workflow
3. Versionize analyzes commits and bumps version
4. CHANGELOG is updated
5. Git tag is created (e.g., `v1.2.0`)
6. GitHub release is published

You can also **manually trigger** the release workflow from the Actions tab.

## CI/CD Workflows

### Release Workflow
- **Trigger**: Push to `main` or manual dispatch
- **Actions**: Version bump, changelog generation, GitHub release creation
- **File**: `.github/workflows/release.yml`

### Build Workflow
- **Trigger**: Push and Pull Requests
- **Actions**: Build verification, test execution, artifact creation
- **File**: `.github/workflows/build.yml`

### Template Cleanup Workflow
- **Trigger**: First push to a new repository from template
- **Actions**: Renames all project files and removes itself
- **File**: `.github/workflows/template-cleanup.yml` (auto-removes)

## Contributing

Contributions are welcome! Please:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes using conventional commits
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This template is available as open source under the MIT License.

## Acknowledgments

- [Spectre.Console](https://spectreconsole.net/) - Amazing library for rich terminal UIs
- [Versionize](https://github.com/versionize/versionize) - Automated versioning tool
- [Conventional Commits](https://www.conventionalcommits.org/) - Commit message convention
