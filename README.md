DockerTest

It's a simple repo to study docker. It has console app, web app and mysql db. Useful link is here https://code-maze.com/mysql-aspnetcore-docker-compose/
In order to make it work, write _dotnet publish_ on solution level folder to generate published versions. After this, use _docker-compose up_ to put all 3 projects inside docker and run them. Access webapi on localhost:5000/WeatherForecast and localhost:5000/Cars

Also there is docker-compose inside DataBase project. You can start only it and access mysql db in docker from webapi project which is running on your pc. If you want to do this, change server name to localhost in connection string.

Many things here are hardcoded (at least for now), so dont consider it as good example.
