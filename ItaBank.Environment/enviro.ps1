param(
	[string] $action
)

if ($action -eq "start") {
	cd docker
	docker-compose up -d
	cd ..
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
