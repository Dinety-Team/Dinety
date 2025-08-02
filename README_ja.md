# Dinety

> [English](./README.md)
> [简体中文](./README_zh.md)
> [Français](README_fr.md)
> [한국어](./README_ko.md)

> [粵語](./README_yue.md)
> [Deutsch](./README_de.md)
> [Русский](./README_ru.md)
> [文言文本](./README_wen.md)

次元をテーマにしたストーリー指向のリズムゲーム。

---

*下記の詳細は現在開発中です。*

## インストール (現在利用不可)

本ゲームは **Windows `x86_64`** および **Android `arm64`** をサポートしています。

### Windows

1. [GitHub リリースページ](https://github.com/Dinety-Team/Dinety/release)からセットアップファイル (.exe) をダウンロード
2. セットアップファイルを実行

### Android

1. [GitHub リリースページ](https://github.com/Dinety-Team/Dinety/release)からファイル (.apk) をダウンロード
2. ファイル (.apk) をインストール

> ### 注意
> 一部のアンチウイルスソフトウェアがインストール
> (Windows/Android) やゲームの実行 (Windows) をブロックする可能性があります
> インストールやゲーム実行がブロックされないことを確認してください

> ### 解決方法
> Windows: アンチウイルスソフトウェアを`無効化`するか、ゲームを`除外リスト`に追加
> Android: インターネット接続を`切断`
---
## ソースコードからのビルド (現在利用不可 & Windowsのみ)

### 1. 依存関係のインストール

1. Git のインストール: <https://git-scm.com/>

2. Visual Studio 2022 のインストール (Community Edition 推奨): <https://visualstudio.microsoft.com/>
    - `Game development with Unity`, `Desktop development with .NET`, `Desktop Development with C++` を選択

3. Rust のインストール: <https://www.rust-lang.org/en-US/tools/install>

4. Unity のインストール: <https://unity.com/unity-hub>
    - バージョン: `2022.3.60f1c1`

### 2. ビルド

1. リポジトリをクローン (`Git Bash` で実行):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. `/RustCode` 内の各フォルダで次を実行:
```pwsh
cargo build --release
```

3. `/RustCode/*/target/release` から `.dll` ファイルを `/Assets/Plugins/x86_64` にコピー
    - `*` は全てのフォルダを意味

4. Unity Editor でゲームをビルド
---
## お問い合わせ

バグ報告や提案は **Issue** を作成してください。

---
## ライセンス

本プロジェクトは [GPL v3.0 ライセンス](LICENSE.md) で公開されています。

[原文](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**