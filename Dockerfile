#Another stage that is all about running the application or how to run
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app

copy /publish ./

#CMD docker instructions tells the docker engine how/where to run this application
entrypoint ["dotnet", "ShoeAppApi.dll"]

#Expose to port 80
expose 5000

env ASPNETCORE_URLS-https//+:5000