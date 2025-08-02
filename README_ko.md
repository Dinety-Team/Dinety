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

차원을 주제로 한 스토리 지향 리듬 게임.

---

*아래 세부사항은 현재 개발 중입니다.*

## 설치 (현재 불가능)

본 게임은 **Windows `x86_64`** 및 **Android `arm64`** 를 지원합니다.

### Windows

1. [GitHub 릴리스 페이지](https://github.com/Dinety-Team/Dinety/release)에서 설치 파일 (.exe) 다운로드
2. 설치 파일 실행

### Android

1. [GitHub 릴리스 페이지](https://github.com/Dinety-Team/Dinety/release)에서 파일 (.apk) 다운로드
2. 파일 (.apk) 설치

> ### 주의사항
> 일부 안티바이러스 소프트웨어가 설치
> (Windows/Android) 및 게임 실행 (Windows) 을 차단할 수 있습니다
> 설치 및 게임 실행이 차단되지 않도록 확인하십시오

> ### 해결방법
> Windows: 안티바이러스 소프트웨어 `비활성화` 또는 게임을 `제외 목록`에 추가
> Android: 인터넷 연결 `차단`
---
## 소스 코드 빌드 (현재 불가능 & Windows 전용)

### 1. 의존성 설치

1. Git 설치: <https://git-scm.com/>

2. Visual Studio 2022 설치 (Community Edition 권장): <https://visualstudio.microsoft.com/>
    - `Game development with Unity`, `Desktop development with .NET`, `Desktop Development with C++` 선택

3. Rust 설치: <https://www.rust-lang.org/en-US/tools/install>

4. Unity 설치: <https://unity.com/unity-hub>
    - 버전: `2022.3.60f1c1`

### 2. 빌드

1. 저장소 복제 (`Git Bash` 에서 실행):
```bash
git clone https://github.com/Dinety-Team/Dinety.git
```

2. `/RustCode` 내 각 폴더에서 다음 실행:
```pwsh
cargo build --release
```

3. `/RustCode/*/target/release` 에서 `.dll` 파일을 `/Assets/Plugins/x86_64` 로 복사
    - `*` 는 모든 폴더 의미

4. Unity Editor 에서 게임 빌드
---
## 문의하기

버그 리포트 또는 제안은 **Issue** 를 생성해 주세요.

---
## 라이선스

본 프로젝트는 [GPL v3.0 라이선스](LICENSE.md) 로 공개됩니다.

[원문](https://www.gnu.org/licenses/gpl-3.0.html#license-text)

---
**Dinety Copyright (c) 2025 Dinety Team**