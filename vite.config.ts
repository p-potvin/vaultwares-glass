import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import dts from 'vite-plugin-dts'
import { resolve } from 'path'

// https://vitejs.dev/guide/build#library-mode
export default defineConfig({
  plugins: [
    react(),
    dts({
      // Resolve outDir to an absolute path so @microsoft/api-extractor (used
      // by rollupTypes) never receives a relative path, which would cause:
      //   "Error: Input file is not an absolute path: dist/vaultwares-glass.d.ts"
      outDir: resolve(__dirname, 'dist'),
      include: ['src'],
      tsconfigPath: resolve(__dirname, 'tsconfig.json'),
      // insertTypesEntry writes a single entry-point declaration file without
      // invoking @microsoft/api-extractor, completely avoiding the relative-
      // path error while still producing a usable dist/vaultwares-glass.d.ts.
      insertTypesEntry: true,
    }),
  ],
  build: {
    lib: {
      entry: resolve(__dirname, 'src/index.ts'),
      name: 'VaultwaresGlass',
      fileName: 'vaultwares-glass',
    },
    rollupOptions: {
      // Peer dependencies must be treated as external so they are not bundled.
      external: ['react', 'react-dom'],
      output: {
        globals: {
          react: 'React',
          'react-dom': 'ReactDOM',
        },
      },
    },
  },
})
