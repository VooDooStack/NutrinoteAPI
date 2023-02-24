migration: 
	dotnet ef migrations add googleMigartion01 -p Persistence -s API
db_update: 
	dotnet ef database update -p Persistence -s API