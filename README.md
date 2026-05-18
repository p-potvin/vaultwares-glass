<img src="https://raw.githubusercontent.com/p-potvin/vaultwares-docs/main/logo/vaultwares-logo.svg">

# vaultwares-glass

**Glass / Acrylic UI Component Library**
**Part of the VaultWares Ecosystem** • <a href="https://docs.vaultwares.com">docs.vaultwares.com</a> • <a href="https://vaultwares.com">vaultwares.com</a>

**A React component library that provides VaultWares glass / acrylic / mica UI primitives for web, plus native demos (Python + WinUI 3) showing equivalent platform effects on Windows.**

Live preview: https://vaultwares-glass-preview.vercel.app

## Features
- React + Vite library mode (UMD + ESM + d.ts)
- Glass, acrylic, and mica surfaces with platform-native fallbacks
- Theme tokens sourced from `vault-themes`
- Native demos: Python (ctypes / DWM) and WinUI 3 (Windows App SDK)
- Tailwind CSS v4 ready
- Playwright smoke tests

## Quick Start

```bash
git clone https://github.com/p-potvin/vaultwares-glass.git
cd vaultwares-glass
git submodule update --init --recursive
npm install
npm run dev
```

To build the library:

```bash
npm run build
```

To run the native demos, see [`native/README.md`](native/README.md).

## Architecture & Agent Integration
Fully synchronized with the VaultWares Agent Knowledge Dissemination System.
- Agents automatically pull latest branding and guidelines from: → https://raw.githubusercontent.com/p-potvin/vaultwares-docs/main/agents/knowledge-dissemination.mdx
- See full details: [Agent Knowledge System](https://raw.githubusercontent.com/p-potvin/vaultwares-docs/main/agents/knowledge-dissemination.mdx)

## Privacy & Security
- No telemetry or external tracking
- Local-first by default
- Full threat model in central VaultWares docs

## Contributing
See [CONTRIBUTING.md](CONTRIBUTING.md) and the central [Brand Guidelines](https://raw.githubusercontent.com/p-potvin/vaultwares-docs/main/agents/branding.mdx).

## License
GPL-3.0 (see [LICENSE](LICENSE))

Built with ❤️ for privacy
