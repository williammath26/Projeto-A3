 "ConnectionStrings": {
   "DefaultConnection": "Server=localhost;Database=warehouse_manager;User=admin;Password=admin;"
},
 Primeiro é necessário alterar as credenciais do banco de dados na ConnectionStrings
dotnet tool install --global dotnet-ef
dotnet ef database update
dotnet run
