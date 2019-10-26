run:
	dotnet run --project=Scooby.Api

build:
	dotnet build

migrate:
	dotnet ef migrations add $(name)  --project=Scooby.Api

update:
	dotnet ef database update --project=Scooby.Api

sql:
	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=1q2w3e4@r' -p 1433:1433    mcr.microsoft.com/mssql/server:2017-latest