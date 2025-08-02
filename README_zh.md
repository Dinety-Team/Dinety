# Dinety 

> [Français](README_fr.md)
> [日本語](./README_ja.md)
> [한국어](./README_ko.md)

> [粵語](./README_yue.md)
> [Deutsch](./README_de.md)
> [Русский](./README_ru.md)

---

一款关于“维度”、以剧情为导向的节奏游戏。

---

*以下内容正处于开发阶段*

## 安装 (尚未可用)

本游戏支持 **`x86_64` 架构** 的 **Windows** 平台与 **`arm64` 架构** 的 **Android** 平台。

### Windows

1. 从 [GitHub 发布页面](https://github.com/Dinety-Team/Dinety/releases/)中下载 Windows 安装程序 (`.exe`).
2. 根据安装程序的指引安装.

### Android

1. 从 [GitHub 发布页面](https://github.com/Dinety-Team/Dinety/releases/)中下载 安装包 (`.apk`).
2. 打开安装包安装.

>### 注意
>安装与/或运行过程中可能会弹出病毒警告以阻止游戏的安装和/或运行. 如果出现, 可以按照以下方法解决: 
>### 解决方法
>- Windows: 关闭设备上的杀毒软件 (例如: Windows Defender) 或将程序添加到白名单.
>- Android: 断网安装.

## 从源代码构建 (尚未可用 & Windows only)

### 1. 安装依赖

1. 下载并安装 Git: <https://git-scm.com/>

2. 安装 Visual Studio 2022, 推荐使用 Community Edition: <https://visualstudio.microsoft.com/zh-hans/>. 
    - 安装时勾选: `使用 Unity 的游戏开发`, `.NET 桌面开发`, `使用 C++ 的桌面开发`.

3. 安装 Rust: <https://www.rust-lang.org/zh-CN/tools/install>

4. 安装 Unity: <https://unity.com/cn/unity-hub>
    - 使用版本: `2022.3.60f1c1`

### 2. 构建项目

1. 在 `Git Bash` 中通过以下命令将仓库克隆到本地:
```
git clone https://github.com/Dinety-Team/Dinety.git
```
2. 打开 `RustCode` 文件夹, 在文件夹下每个目录下执行: 
```
cargo build --release
```
将 `/target/release` 下的 `.dll` 文件复制到 `Assets` 文件夹下的 `plugins/x86_64` 文件夹.

3. 打开 Unity 编辑器构建游戏.

## 许可证

本项目采用[GPL v3.0 许可证](LICENSE_zh.md). 

[许可证原文](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

## 联系我们

在 GitHub 中提交 Issue 以反馈bug/提供建议.

---
Dinety Copyright (c) 2025 Dinety Team

