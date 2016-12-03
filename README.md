# ASP.NET Core tests

#### Init a new test app
`yo aspnet` if `yo` and `generator-aspnet` are installed globally.

If you prefer to install `yo` locally:

```
npm i -D -E yo generator-aspnet
node_modules/.bin/yo aspnet
```

### Run

#### Prepare the app
```
dotnet restore
```

#### Run the app
First, launch the following command to compile the app and sync the database.
```
dotnet build
dotnet ef database update
```

Then launch this command to run the app.
```
dotnet run
```

### Migrations

#### Add a new migration
```
dotnet ef migrations add migrationName
```

#### Remove the last migration
```
dotnet ef migrations remove
```
