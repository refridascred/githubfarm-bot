# GitHubFarm Bot 🌾

**Made by Scred**

The ultimate GitHub profile farming tool. Run it overnight, wake up with a stacked profile.

![.NET Framework 4](https://img.shields.io/badge/.NET_Framework-4.0-blue)
![Windows](https://img.shields.io/badge/platform-Windows-lightgrey)

## Features

### 🟩 Commit Farming
- Generate thousands of realistic commits with proper file changes
- Smart code generation that matches your repo's language
- Backdating support — fill your contribution graph for any time period
- Uses git fast-import for maximum speed (50k commits in seconds)

### 🔀 PR Farming
- Auto-creates branches, commits, opens PRs, and merges them
- Each merged PR = green contribution square
- Farms the **Pull Shark** achievement (2/16/128 merges)

### 🎨 Contribution Graph Art
- Draw text on your GitHub contribution graph
- Built-in pixel font for A-Z
- Paints your name, a word, or anything across the graph

### 🍴 Fork Farming
- Fork popular repos to inflate your repository count
- Auto-searches top-starred repos and forks them

### 📝 Gist Farming
- Mass-create realistic code gists in multiple languages
- Each gist counts as a contribution

### 🏆 Achievement Hunter
One-click farming for ALL GitHub achievements on a single repo:
- **Pull Shark** — merges 128 PRs (bronze → silver → gold)
- **YOLO** — merges without code review
- **Quickdraw** — closes issues within 5 minutes of opening
- **Galaxy Brain** — answers discussion questions
- **Pair Extraordinaire** — co-authored commits
- Creates releases for visibility

### 📊 Activity Feed Flood
- Mixes issues, PRs, releases, and stars
- Makes your activity feed look like a busy developer

### ⭐ Star Farming
- Star popular repos from your account
- Use alt tokens to star YOUR repos (fake stars)

### 👥 Follow Farming
- Auto-follow popular GitHub users
- Reciprocal follow mode

### 📋 Issue Farming
- Auto-create and close issues with realistic titles

### 🏷️ Release Farming
- Auto-create versioned releases with changelogs

### 📖 Wiki Farming
- Auto-create wiki pages via git

### 🏢 Organization Creator
- Create GitHub organizations

### 🔄 Bulk Mode (AFK Overnight)
- Select any combination of features and run them all at once
- Parallel execution for maximum speed
- 8-thread concurrency on all API operations

## Setup

### Quick Start
1. Download `GitHubFarm.exe` from [Releases](../../releases) or build yourself
2. Run it
3. Click **Connect** (uses Git Credential Manager)
4. Select a repo and start farming

### For Follow/Star Farming
Create a **Classic Personal Access Token**:
1. Go to [github.com/settings/tokens](https://github.com/settings/tokens)
2. Generate new token (classic)
3. Check scopes: `repo`, `user`, `gist`, `delete_repo`
4. Paste the token in the **PAT** field before clicking Connect

### Build from Source
```bash
build.bat
```
Or compile directly:
```
%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\csc.exe /nologo /target:winexe /r:System.Web.Extensions.dll /out:GitHubFarm.exe GitHubFarm.cs
```

## How It Works

- GitHub REST API v3 with Bearer token auth
- `git fast-import` for high-speed commit generation
- `ParallelForEach` with configurable thread count
- Realistic commit messages and code file generation
- Built-in self-test suite (`--selftest` flag)

## Disclaimer

For educational purposes. Use responsibly.
