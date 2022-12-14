
param([int] $DayNumber, [string] $solution)


$day = "Day$DayNumber"

git checkout -b "$day"

mkdir "$day"

cd "$day"

$ns = "MJE.Advent"
$sln = "$ns.$solution"
$project = "$sln.Tests.Unit"

dotnet new nunit -n "$project"
dotnet new sln -n "$sln"

dotnet sln "$sln.sln" add "$project\$project.csproj"


git add .
git commit -m "Initial add"
git push --set-upstream origin "$day"


	