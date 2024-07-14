init-project:
	cd rent-car/src && dotnet dev-certs https --trust

launch:
	cd rent-car/src && dotnet run --launch-profile https -v d

test:
	cd rent-car/test && dotnet test
	
launch-utils:
	cd helloworld && dotnet run
