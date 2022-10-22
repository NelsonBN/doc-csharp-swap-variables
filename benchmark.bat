dotnet build restore ./tests/Tests.Benchmarks.csproj
dotnet build -c Release --no-restore ./tests/Tests.Benchmarks.csproj
dotnet run -p ./tests/Tests.Benchmarks.csproj -c Release --no-build