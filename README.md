## Setup

```
mise trust
mise install

if ! which dotnet-ef >/dev/null; then
    dotnet tool install --global dotnet-ef
fi

dotnet ef database update --project DataLayer --startup-project HomeoSapiens
```
