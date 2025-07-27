# Dinety

> [简体中文](./README_zh.md)

A storyline direction's rhythm game about dimension.

---

*The details below is developing.*

## Installation (Not Available Now)

This game supports **Windows `x86_64`** and **Android `arm64`**.

### Windows

1. Download the set up file (.exe) from [GitHub release page](https://github.com/Dinety-Team/Dinety/release).
2. Run the set up file.

### Android

1. Download the file (.apk) from [GitHub release page](https://github.com/Dinety-Team/Dinety/release).
2. Install the file (.apk).

### Notices

Some antivirus software may block the installation
(Windows/Android) and/or the game running (Windows)

Please make sure your antivirus software will not block the 
installation and/or the game running.

Solutions:
Windows: Disable your antivirus software or add the game to your exclusion list.
Android: Cut the connection to the internet.

## Build from Source Code (Not Available Now & Windows Only)

### 1.Install Dependencies

1. Install Git: <https://git-scm.com/>

2. Install Visual Studio 2022, suggests Community Edition: <https://visualstudio.microsoft.com/>
    - Select `Game development with Unity`, `Desktop development with .NET` and `Desktop Development with C++`.

3. Install Rust: <https://www.rust-lang.org/en-US/tools/install>

4. Install Unity: <https://unity.com/unity-hub>
    - Version: `2022.3.60f1c1`

### 2. Build

1. Clone the repository with this command (on `Git Bash`):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. Run this comand on each folder in `/RustCode`:
```pwsh
cargo build --release
```

3. Copy the `.dll` file from `/RustCode/*/target/release` to `/Assets/Plugins/x86_64`.
    - `*` means any (all) folder.

4. Open Unity Editor, build the game.

## Contact us

Commit an **Issue** to report bugs or provide suggestions.

## License

This project is licensed under the [GPL v3.0 License](LICENSE.md).

[Original Text](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---