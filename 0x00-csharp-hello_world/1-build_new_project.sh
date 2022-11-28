#!/usr/bin/env bash
# initializes and builds a new C# project inside a folder titled 1-new_project.
dotnet new console -lang c# -o 1-new_project
dotnet build 1-new_project
