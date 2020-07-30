#using runtime because mobile internet for now
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.6-buster-slim

#where to place app inside image^
WORKDIR /app   

#copy all from publish to image workdir
COPY bin/Debug/netcoreapp3.1/publish /publish


#This means we need to set the application URL manually.
#we can’t use localhost or we won’t be able to bind the port from the docker container to the local environment.

WORKDIR /publish   

# expose port
ENV ASPNETCORE_URLS="http://*:5000" 

#setting what to launch
ENTRYPOINT ["dotnet", "WebApplication.dll"]