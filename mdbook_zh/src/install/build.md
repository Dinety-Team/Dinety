# 从源代码构建 (仅限 Windows)

## 1. 安装依赖

1. 下载并安装 Git: <https://git-scm.com/>

2. 安装 Visual Studio 2022, 推荐使用 Community Edition: <https://visualstudio.microsoft.com/zh-hans/>. 
    - 安装时勾选: `使用 Unity 的游戏开发`, `.NET 桌面开发`, `使用 C++ 的桌面开发`.

3. 安装 Rust: <https://www.rust-lang.org/zh-CN/tools/install>

4. 安装 Unity: <https://unity.com/cn/unity-hub>
    - 使用版本: `2022.3.60f1c1`

## 构建游戏

1. 在 `Git Bash` 中通过以下命令将仓库克隆到本地:
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```
2. 打开 `RustCode` 文件夹, 在文件夹下每个目录下执行: 
```pwsh
cargo build --release
```
将 `/target/release` 下的 `.dll` 文件复制到 `Assets` 文件夹下的 `plugins/x86_64` 文件夹.

3. 打开 Unity 编辑器构建游戏.
3. 


