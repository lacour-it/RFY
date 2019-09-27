plink pi@192.168.2.61 -pw pi!123PI "sudo systemctl stop rfy"
dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true
pushd .\bin\Debug\netcoreapp2.2\linux-arm\publish
pscp -pw pi!123PI -v -r .\* pi@192.168.2.61:/home/pi/projects/rfy
popd
plink pi@192.168.2.61 -pw pi!123PI "sudo systemctl start rfy"