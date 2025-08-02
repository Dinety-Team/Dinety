# Dinety

> [英吉利文本](./.md)
> [漢文本](./README_zh.md)
> [法蘭西文本](README_fr.md)
> [大和文本](./README_ja.md)

> [朝鮮文本](./README_ko.md)
> [粵語本](./README_yue.md)
> [德意志文本](./README_de.md)
> [露西亞文本](./README_ru.md)

維度之道，節奏為戲，敘事為綱。

---

*下述諸事，尚在營造之中。*

## 安裝法（今不可得）

是戲可馳於 **Windows `x86_64`** 並 **Android `arm64`** 之器。

### Windows

1. 自 [GitHub 釋出頁](https://github.com/Dinety-Team/Dinety/release) 取佈置之文（.exe）
2. 行佈置之文

### Android

1. 自 [GitHub 釋出頁](https://github.com/Dinety-Team/Dinety/release) 取安機之文（.apk）
2. 置安機之文

> ### 告示
> 或有防毒之器阻其佈置
> (Windows/Android) 及/或 戲之運行 (Windows)
> 當確汝之防毒器不阻其事

> ### 解法
> Windows: `止防毒之器` 或 添戲入 `赦免之錄`
> Android: `斷` 網絡之連
---
## 自源碼營造（今不可得 & 唯Windows）

### 一. 置必備之物

1. 置 Git：<https://git-scm.com/>

2. 置 Visual Studio 2022，薦民衆版：<https://visualstudio.microsoft.com/>
    - 擇 `以Unity營戲`，`以.NET築臺` 並 `以C++築臺`

3. 置 Rust：<https://www.rust-lang.org/en-US/tools/install>

4. 置 Unity：<https://unity.com/unity-hub>
    - 版號：`2022.3.60f1c1`

### 二. 營造

1. 取庫藏於此令（於 `Git Bash`）：
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. 行此令於 `/RustCode` 中各軒：
```pwsh
cargo build --release
```

3. 取 `.dll` 之文自 `/RustCode/*/target/release` 置 `/Assets/Plugins/x86_64`
    - `*` 謂諸軒

4. 啓 Unity Editor，營造此戲
---
## 通吾儕

立 **Issue** 以稟蟲豸，或呈良策。

---
## 契書

是業循 [GPL v3.0 契書](LICENSE.md)。

[原文](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety 版權所有 (c) 2025 Dinety 衆**