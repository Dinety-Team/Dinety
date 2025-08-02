# Dinety

> [简体中文](./README_zh.md)
> [Français](README_fr.md)
> [日本語](./README_ja.md)

> [한국어](./README_ko.md)
> [Deutsch](./README_de.md)
> [Русский](./README_ru.md)

關於維度嘅故事導向節奏遊戲。

---

*以下詳情而家開發緊。*

## 安裝 (暫時未提供)

本遊戲支援 **Windows `x86_64`** 同 **Android `arm64`**。

### Windows

1. 從 [GitHub 發佈頁](https://github.com/Dinety-Team/Dinety/release) 下載安裝檔 (.exe)
2. 運行安裝檔

### Android

1. 從 [GitHub 發佈頁](https://github.com/Dinety-Team/Dinety/release) 下載檔案 (.apk)
2. 安裝檔案 (.apk)

> ### 注意
> 部分防毒軟件可能會阻擋安裝
> (Windows/Android) 同遊戲運行 (Windows)
> 請確保你嘅防毒軟件唔會阻擋安裝同遊戲運行

> ### 解決方法
> Windows: `停用防毒軟件` 或將遊戲加入`例外清單`
> Android: `切斷` 網絡連接
---
## 從源碼編譯 (暫時未提供 & 只限Windows)

### 1. 安裝依賴

1. 安裝 Git: <https://git-scm.com/>

2. 安裝 Visual Studio 2022 (建議 Community 版): <https://visualstudio.microsoft.com/>
    - 選擇 `Game development with Unity`, `Desktop development with .NET` 同 `Desktop Development with C++`

3. 安裝 Rust: <https://www.rust-lang.org/en-US/tools/install>

4. 安裝 Unity: <https://unity.com/unity-hub>
    - 版本: `2022.3.60f1c1`

### 2. 編譯

1. 克隆倉庫 (喺 `Git Bash` 運行):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. 喺 `/RustCode` 每個文件夾運行:
```pwsh
cargo build --release
```

3. 從 `/RustCode/*/target/release` 複製 `.dll` 檔案去 `/Assets/Plugins/x86_64`
    - `*` 代表所有文件夾

4. 用 Unity Editor 編譯遊戲
---
## 聯絡我哋

提交 **Issue** 報告問題或提供建議。

---
## 授權

本項目採用 [GPL v3.0 授權](LICENSE.md)。

[原文](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**