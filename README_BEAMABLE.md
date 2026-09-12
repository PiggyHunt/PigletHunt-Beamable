# Beamable CLI

---

## Requirements     

Make sure you have the following installed:

- Docker [(Download)](https://docs.docker.com/desktop/setup/install/windows-install/)

---

## Setup

```powershell
dotnet tool install --global Beamable.Tools
dotnet beam init (if fresh)
dotnet beam login
dotnet beam config
dotnet tool update beamable.tools -g
```

---

## Creating a microservice

```powershell
dotnet beam project new service <ServiceName>

# Example:
dotnet beam project new service MigrateMicroService
```

---

## Building & deploying

```powershell
dotnet build
dotnet clean
dotnet restore
dotnet build
dotnet beam deploy release --comment "<description of the change>"
```

---

## Setting up content

```powershell
dotnet beam content new-manifest global
dotnet beam content publish
```