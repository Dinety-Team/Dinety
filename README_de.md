# Dinety

> [简体中文](./README_zh.md)
> [Français](README_fr.md)
> [日本語](./README_ja.md)

> [한국어](./README_ko.md)
> [粵語](./README_yue.md)
> [Русский](./README_ru.md)

Ein Story-basiertes Rhythmusspiel über Dimensionen.

---

*Die folgenden Details befinden sich in der Entwicklung.*

## Installation (Derzeit nicht verfügbar)

Dieses Spiel unterstützt **Windows `x86_64`** und **Android `arm64`**.

### Windows

1. Installationsdatei (.exe) von [GitHub Release-Seite](https://github.com/Dinety-Team/Dinety/release) herunterladen
2. Installationsdatei ausführen

### Android

1. Datei (.apk) von [GitHub Release-Seite](https://github.com/Dinety-Team/Dinety/release) herunterladen
2. Datei (.apk) installieren

> ### Hinweis
> Einige Antivirenprogramme können die Installation
> (Windows/Android) und/oder Spielausführung (Windows) blockieren
> Bitte stellen Sie sicher, dass Ihr Antivirenprogramm die Installation und/oder Spielausführung nicht blockiert

> ### Lösung
> Windows: `Deaktivieren Sie Ihr Antivirenprogramm` oder fügen Sie das Spiel zur `Ausnahmeliste` hinzu
> Android: `Trennen Sie die Internetverbindung`
---
## Aus Quellcode bauen (Derzeit nicht verfügbar & Nur Windows)

### 1. Abhängigkeiten installieren

1. Git installieren: <https://git-scm.com/>

2. Visual Studio 2022 installieren (Community Edition empfohlen): <https://visualstudio.microsoft.com/>
    - Wählen Sie `Game development with Unity`, `Desktop development with .NET` und `Desktop Development with C++`

3. Rust installieren: <https://www.rust-lang.org/en-US/tools/install>

4. Unity installieren: <https://unity.com/unity-hub>
    - Version: `2022.3.60f1c1`

### 2. Bauen

1. Repository klonen (in `Git Bash` ausführen):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. In jedem Ordner unter `/RustCode` ausführen:
```pwsh
cargo build --release
```

3. Kopieren Sie `.dll`-Dateien von `/RustCode/*/target/release` nach `/Assets/Plugins/x86_64`
    - `*` bedeutet alle Ordner

4. Spiel in Unity Editor bauen
---
## Kontakt

Erstellen Sie ein **Issue**, um Fehler zu melden oder Vorschläge zu machen.

---
## Lizenz

Dieses Projekt steht unter der [GPL v3.0 Lizenz](LICENSE.md).

[Originaltext](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**