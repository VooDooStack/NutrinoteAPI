add_migration:
	dotnet ef migrations add $(name) -s API -p Persistence
remove_migration:
	dotnet ef migrations remove -s API -p Persistence
update_db:
	dotnet ef database update -s API -p Persistence
run: 
	cd API && dotnet watch run --no-hot-reload && cd -
clean:
	dotnet clean
	dotnet restore
