# CRUD de Productos — API en .NET

Proyecto de práctica para Programación III. API REST sencilla con operaciones
CRUD (Crear, Leer, Actualizar, Eliminar) sobre una entidad `Producto`,
almacenada en memoria.

## Requisitos
- .NET 8 SDK

## Cómo correrlo
```bash
dotnet restore
dotnet run
```

Luego abre `https://localhost:{puerto}/swagger` para probar los endpoints.

## Endpoints
| Método | Ruta                  | Descripción              |
|--------|-----------------------|---------------------------|
| GET    | /api/productos        | Lista todos los productos |
| GET    | /api/productos/{id}   | Obtiene un producto       |
| POST   | /api/productos        | Crea un producto          |
| PUT    | /api/productos/{id}   | Actualiza un producto     |
| DELETE | /api/productos/{id}   | Elimina un producto       |

## Flujo de trabajo
Este repositorio sigue **Git Flow**: ramas `main`, `dev` y `qa`, con ramas
`feature/` y `hotfix/` para cada unidad de trabajo. Ver `GUIA_GITFLOW.md`.
