# Dinety

> [简体中文](./README_zh.md)
>
> [Français](README_fr.md)
>
> [日本語](./README_ja.md)
>
> [한국어](./README_ko.md)
>
> [粵語](./README_yue.md)
>
> [Deutsch](./README_de.md)
>
> [Русский](./README_ru.md)

Ритм-игра с сюжетной линией о измерениях.

---

*Следующие детали в разработке.*

## Установка (Сейчас недоступна)

Игра поддерживает **Windows `x86_64`** и **Android `arm64`**.

### Windows

1. Скачать установочный файл (.exe) со [страницы релизов GitHub](https://github.com/Dinety-Team/Dinety/release)
2. Запустить установочный файл

### Android

1. Скачать файл (.apk) со [страницы релизов GitHub](https://github.com/Dinety-Team/Dinety/release)
2. Установить файл (.apk)

> ### Внимание
> Некоторые антивирусы могут блокировать установку
> (Windows/Android) и/или запуск игры (Windows)
> Убедитесь, что ваш антивирус не блокирует установку и/или запуск игры

> ### Решение
> Windows: `Отключите антивирус` или добавьте игру в `исключения`
> Android: `Отключите` интернет-соединение
---
## Сборка из исходного кода (Сейчас недоступна & Только Windows)

### 1. Установка зависимостей

1. Установите Git: <https://git-scm.com/>

2. Установите Visual Studio 2022 (рекомендуется Community Edition): <https://visualstudio.microsoft.com/>
    - Выберите `Game development with Unity`, `Desktop development with .NET` и `Desktop Development with C++`

3. Установите Rust: <https://www.rust-lang.org/en-US/tools/install>

4. Установите Unity: <https://unity.com/unity-hub>
    - Версия: `2022.3.60f1c1`

### 2. Сборка

1. Клонируйте репозиторий (в `Git Bash`):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. В каждой папке в `/RustCode` выполните:
```pwsh
cargo build --release
```

3. Скопируйте `.dll` файлы из `/RustCode/*/target/release` в `/Assets/Plugins/x86_64`
    - `*` означает все папки

4. Соберите игру в Unity Editor
---
## Связь с нами

Создайте **Issue** для сообщения об ошибках или предложений.

---
## Лицензия

Проект лицензирован под [GPL v3.0](LICENSE.md).

[Оригинальный текст](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**