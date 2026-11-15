# AsciiBit Hub

Aplicación de escritorio desarrollada en **C# y Windows Forms** para convertir caracteres ASCII, números decimales y valores binarios.

El proyecto reúne varias herramientas de conversión en una interfaz sencilla, con navegación por módulos y validación de entradas.

![.NET](https://img.shields.io/badge/.NET-Windows%20Forms-512BD4?style=flat-square&logo=dotnet)
![C%23](https://img.shields.io/badge/C%23-Language-239120?style=flat-square)
![Windows](https://img.shields.io/badge/Platform-Windows-0078D4?style=flat-square)

## Funcionalidades

### Conversión ASCII

- Conversión de caracteres a códigos numéricos y viceversa.
- Manejo de valores entre **0 y 255**, según la codificación implementada.
- Validación de entradas mediante controles `NumericUpDown` y `TextBox`.

> **Nota:** Los caracteres superiores al código 127 dependen de la página de códigos utilizada. ASCII estándar solo define los códigos del 0 al 127.

### Conversión de bases numéricas

- Conversión de **binario a decimal**.
- Conversión de **decimal a binario**.
- Validación de valores antes de ejecutar las conversiones.

### Interfaz

- Menú lateral para navegar entre módulos.
- Vistas organizadas mediante `UserControl`.
- Uso de la tecla **Enter** para realizar conversiones.
- Tema oscuro.
- Enlace de consulta a [ASCII Code](https://www.ascii-code.com/).

## Tecnologías

| Tecnología | Uso |
|---|---|
| C# | Lógica de la aplicación |
| .NET | Plataforma de ejecución |
| Windows Forms | Interfaz gráfica |
| UserControl | Organización de las vistas |
| Visual Studio | Desarrollo y depuración |

## Instalación

**Requisitos:** Windows, Visual Studio con herramientas de desarrollo de escritorio .NET y la versión de .NET correspondiente al proyecto.

1. Clona el repositorio:

   ```bash
   git clone https://github.com/JBatistasBytes/AsciiBitHub.git
   ```

2. Abre la carpeta:

   ```bash
   cd AsciiBitHub
   ```

3. Abre el archivo `.sln` en Visual Studio.
4. Restaura las dependencias, compila la solución y ejecuta la aplicación.

## Uso

1. Abre **AsciiBit Hub**.
2. Selecciona el módulo de conversión en el menú lateral.
3. Introduce el carácter o número que deseas convertir.
4. Presiona **Enter** y consulta el resultado.

### Ejemplos

| Entrada | Conversión | Resultado |
|---|---|---|
| `A` | Carácter a ASCII decimal | `65` |
| `65` | ASCII decimal a carácter | `A` |
| `1010` | Binario a decimal | `10` |
| `25` | Decimal a binario | `11001` |

## Autor

**Jean Luis Batista**  
GitHub: [@JBatistasBytes](https://github.com/JBatistasBytes)

## Licencia

Si el repositorio incluye el archivo `LICENSE` con los términos de la licencia MIT, el proyecto se distribuye bajo esa licencia.
