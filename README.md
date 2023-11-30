## Comand to run the API
```powershell
dotnet watch --no-hot-reload
```

## Add migrations
```powershell
dotnet ef migrations add InitialCreate -p .\Infrastructure\ -s .\API\ -o Data/Migrations

dotnet ef database update
```

Using NVM to control Node version:
https://github.com/coreybutler/nvm-windows

## Run the angular APP
```powershell
ng serve
```

## Create components in Angular
```powershell
ng g c nav-bar
```