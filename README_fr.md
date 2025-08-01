# Dinety

> [简体中文](./README_zh.md)
>
> [English](./README.md)

Jeu de rythme narratif sur le thème des dimensions.

---

*Les détails ci-dessous sont en cours de développement.*

## Installation (Indisponible actuellement)

Ce jeu supporte **Windows `x86_64`** et **Android `arm64`**.

### Windows

1. Téléchargez le fichier d'installation (.exe) depuis la [page des versions GitHub](https://github.com/Dinety-Team/Dinety/release).
2. Exécutez le fichier d'installation.

### Android

1. Téléchargez le fichier (.apk) depuis la [page des versions GitHub](https://github.com/Dinety-Team/Dinety/release).
2. Installez le fichier (.apk).

---

>[!TIP]
>Certains logiciels antivirus peuvent bloquer l'installation
(Windows/Android) et/ou le fonctionnement du jeu (Windows)
>Assurez-vous que votre logiciel antivirus ne bloquera pas 
l'installation et/ou le fonctionnement du jeu.

>[!IMPORTANT]
>Windows : `Désactivez votre logiciel antivirus` ou ajoutez le jeu à votre `liste d'exclusions`.
>Android : `Coupez la connexion` à Internet.

---

## Compilation à partir du code source (Indisponible actuellement & Windows uniquement)

### 1. Installer les dépendances

1. Installez Git : <https://git-scm.com/>

2. Installez Visual Studio 2022, version Community recommandée : <https://visualstudio.microsoft.com/fr/>
    - Sélectionnez `Développement de jeux avec Unity`, `Développement .NET pour le bureau` et `Développement C++ pour le bureau`.

3. Installez Rust : <https://www.rust-lang.org/fr/tools/install>

4. Installez Unity : <https://unity.com/fr/unity-hub>
    - Version : `2022.3.60f1c1`

### 2. Compiler

1. Clonez le dépôt avec cette commande (dans `Git Bash`) :
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. Exécutez cette commande dans chaque dossier de `/RustCode` :
```pwsh
cargo build --release
```

3. Copiez le fichier `.dll` depuis `/RustCode/*/target/release` vers `/Assets/Plugins/x86_64`.
    - `*` signifie tout dossier (tous les dossiers).

4. Ouvrez l'éditeur Unity et compilez le jeu.

---

## Nous contacter

Ouvrez une **Issue** pour signaler des bugs ou faire des suggestions.

---

## Licence

Ce projet est sous licence [GPL v3.0](LICENSE_fr.md).

[Texte original](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**
