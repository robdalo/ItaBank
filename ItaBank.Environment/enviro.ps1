param(
	[string] $action
)

if ($action -eq "start") {
	cd docker
	docker-compose up -d
	cd ..
	write-output "Wait 15 seconds to ensure containers have spun up before proceeding..."
	sleep 15
	msbuild ..\ItaBank.Database\ItaBank.Database.sqlproj /p:Configuration=Release
	SqlPackage.exe /a:Publish /sf:"..\ItaBank.Database\bin\Release\ItaBank.Database.dacpac" /tcs:"Server=lunatic;Database=ItaBank;User Id=sa;Password=b11a8fe75d7866ee3fB1f871589493123;"
	sqlcmd -S localhost -U sa -P b11a8fe75d7866ee3fB1f871589493123 -Q "exec ItaBank.dbo.LoadDummyData;"
}
elseif ($action -eq "stop") {
	cd docker
	docker-compose stop
	cd ..
}
elseif ($action -eq "reset") {
	cd docker
	docker-compose stop
	docker-compose rm -f
	docker volume prune -f
	cd ..
}
elseif ($action -eq "destroy") {
	cd docker
	docker-compose stop
	docker-compose rm -f
	docker image prune -a -f
	docker volume prune -f
	cd ..
}
