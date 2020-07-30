#using runtime because mobile internet for now
FROM mcr.microsoft.com/dotnet/core/runtime:3.1 

#where to place app inside image^
WORKDIR /app   

#copy all from publish to image workdir
COPY bin/Debug/netcoreapp3.1/publish .

#setting what to launch
ENTRYPOINT ["dotnet", "ConsoleApp.dll"]