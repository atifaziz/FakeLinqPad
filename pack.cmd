@echo off
pushd "%~dp0"
if not exist dist mkdir dist || goto :end
nuget pack -Symbols -OutputDirectory "dist" src\FakeLinqPad.csproj %*
:end
popd
