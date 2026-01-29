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
4. **Activate auto-rename** (choose one method):

#### Method A: Make any commit (Recommended)
```bash
git clone https://github.com/YOUR_USERNAME/YOUR_REPO.git
cd YOUR_REPO

# Make any small change
echo "# My Project" >> README.md
git add README.md
git commit -m "docs: update readme"
git push

# ✨ The template cleanup will run automatically!
```

#### Method B: Manual trigger via GitHub UI
1. Go to your repository's **Actions** tab
2. Click on **"Template Cleanup"** workflow
3. Click **"Run workflow"** → **"Run workflow"**

### What Happens Automatically

Once triggered, the template will:
- ✅ Rename all `MyTuiApp` occurrences to your repository name
- ✅ Update all file names and directory names
- ✅ Update solution and project files
- ✅ Update README badges with your repository info
- ✅ Remove the template cleanup workflow itself
- ✅ Create a commit: `chore: rename project from template to YourProjectName`

### Naming Conventions

If you name your repository `my-cool-app`, the template creates:

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
# Build with Native AOT for your platform
dotnet publish -c Release

# Output location: src/YOUR_PROJECT_NAME/bin/Release/net8.0/[runtime]/publish/
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
│       ├── Commands/          # CLI commands
│       ├── MyTuiApp.csproj    # Project file
│       └── Program.cs         # Application entry point
├── .github/
│   └── workflows/             # GitHub Actions workflows
│       ├── release.yml        # Automated release workflow
│       ├── build-publish.yml  # CI build workflow
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

Releases are **automatically created** when you push commits with conventional commit messages to `main`:

1. Make commits using conventional commit format
2. Push to `main` branch
3. GitHub Actions runs the release workflow
4. Versionize analyzes commits and bumps version
5. CHANGELOG is updated
6. Git tag is created (e.g., `v1.2.0`)
7. GitHub release is published with binaries

You can also **manually trigger** the release workflow:
1. Go to **Actions** tab
2. Select **"Release"** workflow
3. Click **"Run workflow"**

## CI/CD Workflows

### Release Workflow
- **File**: `.github/workflows/release.yml`
- **Trigger**: Push to `main` with conventional commits, or manual dispatch
- **Actions**: 
  - Analyzes commits since last release
  - Bumps version in project files
  - Generates CHANGELOG
  - Creates Git tag
  - Publishes GitHub release

### Build & Publish Workflow
- **File**: `.github/workflows/build-publish.yml`
- **Trigger**: Push and Pull Requests
- **Actions**: 
  - Builds project for all platforms
  - Runs tests
  - Creates artifacts
  - Attaches binaries to releases

### Template Cleanup Workflow
- **File**: `.github/workflows/template-cleanup.yml`
- **Trigger**: First push to a new repository from template, or manual dispatch
- **Actions**: 
  - Detects repository name
  - Renames all project files and directories
  - Updates file contents
  - Removes itself
- **Note**: This workflow auto-removes after first successful run

## Troubleshooting

### Template didn't auto-rename

If the auto-rename didn't work:
1. Check the **Actions** tab for workflow run status
2. Manually trigger the "Template Cleanup" workflow
3. Or make a small commit to trigger it

### Release workflow not creating tags

Make sure:
- You're using conventional commit messages (`feat:`, `fix:`, etc.)
- Commits are pushed to the `main` branch
- You have at least one `feat:` or `fix:` commit since initialization

### Build errors after renaming

1. Clean and rebuild: `dotnet clean && dotnet build`
2. Check that all references were updated correctly
3. Verify `.csproj` and `.sln` files have correct project names

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
