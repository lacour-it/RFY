dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true
pushd .\bin\Debug\netcoreapp2.2\linux-arm\publish
pscp -pw pi!jos10Tgya -v -r .\* pi@192.168.2.61:/home/pi/projects/rfy
popd