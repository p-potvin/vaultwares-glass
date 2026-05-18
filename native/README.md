# vaultwares-glass · Native Demos

Platform-native glass / transparency effects that complement the web-based
`vaultwares-glass` React library.

---

## Python  (`python/glass_demo.py`)

Uses **ctypes** to call Windows DWM APIs directly — zero third-party
dependencies.

| Effect  | API                                         | Minimum OS          |
| ------- | ------------------------------------------- | ------------------- |
| Blur    | `SetWindowCompositionAttribute` (Blur)      | Windows 10          |
| Acrylic | `SetWindowCompositionAttribute` (Acrylic)   | Windows 10 1803     |
| Mica    | `DwmSetWindowAttribute` (SystemBackdrop)    | Windows 11 22H2     |

### Run

```bash
cd native/python
python glass_demo.py
```

---

## WinUI 3  (`winui3/GlassDemo/`)

A C# / WinUI 3 app using the official **Windows App SDK** backdrop controllers.

| Material | Controller                  | Minimum OS      |
| -------- | --------------------------- | --------------- |
| Mica     | `MicaController`            | Windows 11      |
| Mica Alt | `MicaController` (BaseAlt)  | Windows 11      |
| Acrylic  | `DesktopAcrylicController`  | Windows 10 1809 |

### Build & Run

```bash
cd native/winui3/GlassDemo
dotnet restore
dotnet run
```

> Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
> and the Windows App SDK workload (`dotnet workload install windowsappruntime`).
