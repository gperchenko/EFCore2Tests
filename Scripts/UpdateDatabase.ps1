param([string] $name )

dotnet ef database update $name --verbose --project EFTests.Migrations --startup-project EFTests.ConsoleApp