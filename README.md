# Login (Windows Forms)

Proyecto de práctica en **C# / Windows Forms** para iniciar sesión y abrir una ventana principal.

**Regla del equipo:** no se trabaja ni se sube código directo a `main`. Cada persona usa su propia rama y un Pull Request.

---

## Qué necesitas

- [Git](https://git-scm.com/download/win)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (carga de trabajo **Desarrollo de escritorio de .NET**) o el SDK de .NET
- Una cuenta de GitHub con acceso al repositorio
- Terminal (Git Bash, PowerShell o la terminal de Visual Studio / Cursor)

Comprueba Git:

```bash
git --version
```

---

## 1. Clonar el repositorio

Copia la URL del repo en GitHub: botón verde **Code** → **HTTPS**.

```bash
git clone https://github.com/brandonrdzdev/login.git
cd login
```

Si ya lo clonaste antes, actualiza `main` (solo lectura; no desarrolles ahí):

```bash
git checkout main
git pull origin main
```

---

## 2. Crear tu rama (obligatorio)

`main` está protegida. Un `git push` directo a `main` será rechazado.

Nombre sugerido: `feature/TuNombre` (ejemplo: `feature/Ana`).

```bash
git checkout main
git pull origin main
git checkout -b feature/TuNombre
```

Confirma que no estás en `main`:

```bash
git branch
```

La rama activa aparece con `*`.

---

## 3. Abrir y ejecutar el proyecto

1. Abre `login.slnx` en Visual Studio.
2. Inicia el proyecto (F5).
3. Para probar el login de demostración:
   - Usuario: `admin`
   - Contraseña: `1234`

---

## 4. Guardar cambios y subirlos

Revisa qué cambió:

```bash
git status
git diff
```

Agrega archivos, confirma y sube **tu rama**:

```bash
git add .
git commit -m "feat: describe el cambio en una frase"
git push -u origin feature/TuNombre
```

Mensajes útiles:

| Prefijo | Cuándo usarlo |
| --- | --- |
| `feat:` | Funcionalidad nueva |
| `fix:` | Corrección de un error |
| `docs:` | Documentación |

---

## 5. Abrir un Pull Request hacia `main`

1. En GitHub, abre el repositorio.
2. Aparece **Compare & pull request** (o ve a **Pull requests** → **New pull request**).
3. Base: `main`. Compare: `feature/TuNombre`.
4. Título y descripción claros.
5. Crea el PR y pide revisión. **No hagas merge a `main` sin aprobación.**

Si GitHub te pide actualizar tu rama porque `main` avanzó:

```bash
git checkout feature/TuNombre
git fetch origin
git merge origin/main
git push
```

Resuelve conflictos en el editor, haz `git add` de los archivos corregidos y un commit.

---

## Flujo diario (resumen)

```text
clonar → crear rama → programar → commit → push de TU rama → Pull Request → revisión → merge a main
```

No hagas esto:

```bash
git checkout main
git commit ...
git push origin main
```

Ese push fallará por la protección de la rama.

---

## Comandos de apoyo

| Acción | Comando |
| --- | --- |
| Ver rama actual | `git branch --show-current` |
| Ver remotos | `git remote -v` |
| Descargar sin cambiar archivos | `git fetch origin` |
| Ver últimos commits | `git log --oneline -10` |
| Descartar cambios de un archivo (cuidado) | `git checkout -- archivo` |

---

## Estructura del proyecto

```text
login/
  login.slnx          Solución de Visual Studio
  login/
    Program.cs        Punto de entrada
    Form1.cs          Formulario de login (FrmLogin)
    FrmPrincipal.cs   Ventana después de iniciar sesión
```

---

## Problemas frecuentes

**“rejected” o “protected branch” al hacer push**  
Estás intentando subir a `main`. Cambia a tu rama y vuelve a hacer push:

```bash
git checkout feature/TuNombre
git push -u origin feature/TuNombre
```

**No aparece tu rama en GitHub**  
Falta el `git push -u origin feature/TuNombre`.

**Visual Studio no abre la solución**  
Instala la carga de trabajo de escritorio .NET y abre `login.slnx`.

**Git pide usuario y contraseña**  
Usa un [Personal Access Token](https://github.com/settings/tokens) o GitHub Desktop / Git Credential Manager; no uses la contraseña de la cuenta.

---

## Dudas

Pregunta en clase o deja un comentario en el Pull Request. No subas archivos de OneDrive ni copies el mismo formulario dos veces en el proyecto: eso duplica clases y rompe la compilación.
