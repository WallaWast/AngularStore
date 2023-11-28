## Comand to run the API
```powershell
dotnet watch --no-hot-reload
```

## Add migrations
```powershell
dotnet ef migrations add InitialCreate -o Data/Migrations

dotnet ef database update
```
