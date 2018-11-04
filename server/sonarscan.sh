dotnet sonarscanner begin /k:"expensetracker" /d:"sonar.exclusions=**/Migrations/**"
dotnet build Vdias.ExpenseTracker.Main
dotnet sonarscanner end