#!/bin/bash

cd /workspaces/visitor-keeper/VisitorKeeper.Infrastructure
dotnet ef database update -s ../VisitorKeeper.WebApi/VisitorKeeper.WebApi.csproj 