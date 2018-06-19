@echo off

echo "Windows Docker build"

cd ../AspNetCore.Docker

dotnet publish -c Release -o ../publish

cd ../publish

echo "publish success"

docker build -t aspnetcoredocker .