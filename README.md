DockerTest

It's a simple repo to study docker. It has console app, web app and mysql db. Useful link is here https://code-maze.com/mysql-aspnetcore-docker-compose/
In order to make it work, write _dotnet publish_ on solution level folder to generate published versions. After this, use _docker-compose up_ to put all 3 projects inside docker and run them. Access webapi on localhost:5000/WeatherForecast and localhost:5000/Cars
