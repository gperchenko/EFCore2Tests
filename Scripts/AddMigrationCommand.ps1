param([string] $name )

dotnet ef migrations add $name --project EFTests.Migrations --startup-project EFTests.ConsoleApp