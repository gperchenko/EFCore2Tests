param([string] $name )

dotnet ef migrations add $name --verbose --project EFTests.Migrations --startup-project EFTests.ConsoleApp