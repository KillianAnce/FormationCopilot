init-project:
	cd rent-car/src && dotnet dev-certs https --trust

launch:
	cr rent-car/test && dotnet test
	cd rent-car/src && dotnet run --launch-profile https

launch-utils:
	cd helloworld && dotnet run
