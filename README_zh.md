# Dinety 
> [English](./README.md)
---

一款关于“维度”、以剧情为导向的节奏游戏。

---

*以下内容正处于开发阶段*

# 安装 (尚未可用)

本游戏支持 **`x86_64`架构** 的 **Windows** 平台与 **`arm64`架构** 的 **Android** 平台。

## Windows

1. 从 [GitHub 发布页面](https://github.com/Dinety-Team/Dinety/releases/)中下载 Windows 安装程序 (`.exe`).
2. 根据安装程序的指引安装.

## Android

1. 从 [GitHub 发布页面](https://github.com/Dinety-Team/Dinety/releases/)中下载 安装包 (`.apk`).
2. 打开安装包安装.

## 注意事项

安装与/或运行过程中可能会弹出病毒警告以组织游戏的安装和/或运行. 如果出现, 可以按照以下方法解决: 
- Windows: 关闭设备上的杀毒软件 (例如: Windows Defender) 或将程序添加到白名单.
- Android: 断网安装.

# 从源代码构建 (尚未可用 & Windows only)

0. 安装依赖

依赖列表: 
- [Git](https://git-scm.com/)
- [Rust 开发环境](https://www.rust-lang.org/zh-CN/tools/install)
- [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/). 安装时勾选: 使用Unity的游戏开发, .NET桌面开发.
- [Unity](https://unity.com/cn/unity-hub). 安装版本: `2022.3.60f1c1` (2025/07 前的最新 LTS 版本)

1. 通过以下命令将仓库克隆到本地:
```
git clone https://github.com/Dinety-Team/Dinety.git
```
2. 打开 `RustCode` 文件夹, 在文件夹下每个目录下执行: 
```
cargo build --release
```
将 `/target/release` 下的 `.dll` 复制到 `Assets` 文件夹下的 `plugins/windows` 文件夹.
3. 打开 Unity 编辑器构建游戏.

# 联系我们

在 GitHub 中提交 Issue 以反馈bug/提供建议.

---


