# Cómo importar estos Snippets en Visual Studio

Estos archivos `.snippet` son compatibles con cualquier versión de Visual Studio (2022 / 2019).

## Pasos para importar en la otra máquina (30 segundos):

1. Abre **Visual Studio**.
2. Ve al menú superior: **Herramientas** (`Tools`) ➔ **Administrador de fragmentos de código** (`Code Snippets Manager`) o presiona el atajo **`Ctrl + K, Ctrl + B`**.
3. En el desplegable **Lenguaje**, selecciona **CSharp**.
4. Haz clic en el botón **Importar...** (`Import...`).
5. Selecciona los 6 archivos `.snippet` de esta carpeta.
6. Elige la carpeta donde guardarlos (por defecto **Mis fragmentos de código** / *My Code Snippets*) y presiona **Finalizar**.

---

## Atajos disponibles (Escribir atajo + `Tab` + `Tab`):

| Atajo | Archivo | Descripción |
|---|---|---|
| `adcontext` | `adcontext.snippet` | DbContext con LocalDB, `EnsureCreated` y conversión Enum a string |
| `adrepo` | `adrepo.snippet` | Repositorio asíncrono completo con EF Core |
| `adserv` | `adserv.snippet` | Servicio con llamadas asíncronas, validaciones y mapeo DTO |
| `adendpoints` | `adendpoints.snippet` | Endpoints minimalistas y asíncronos para la Web API |
| `adapiclient` | `adapiclient.snippet` | Cliente HTTP estático y métodos con `System.Net.Http.Json` |
| `adwinforms` | `adwinforms.snippet` | Métodos de WinForms: Carga de Enum en ComboBox, filtro y grilla |

> **Nota:** Al insertar el snippet, los nombres de variables (como `Entidad`, `dbParcial`, etc.) quedan resaltados para que los cambies una sola vez con `Tab`.
