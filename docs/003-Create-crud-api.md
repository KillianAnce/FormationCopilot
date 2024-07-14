# Créer un CRUD API avec .NET 8

Pour créer un CRUD API avec .NET 8 en utilisant GitHub Copilot, vous pouvez suivre les étapes suivantes :

1. Commencez par créer un nouveau projet .NET 8 en utilisant la commande `dotnet new webapi` dans votre terminal.

2. Une fois le projet créé, ouvrez le fichier `Startup.cs` et configurez les services et les middlewares nécessaires pour votre API.

3. Créez un nouveau dossier dans votre projet pour stocker vos modèles de données. Vous pouvez utiliser la commande `mkdir Models` dans votre terminal.

4. À l'intérieur du dossier `Models`, créez une classe pour chaque modèle de données que vous souhaitez utiliser dans votre API. Par exemple, vous pouvez créer une classe `User` avec des propriétés telles que `Id`, `Name`, `Email`, etc.

5. Créez un nouveau dossier dans votre projet pour stocker vos contrôleurs. Vous pouvez utiliser la commande `mkdir Controllers` dans votre terminal.

6. À l'intérieur du dossier `Controllers`, créez un contrôleur pour chaque modèle de données que vous avez créé précédemment. Par exemple, vous pouvez créer un contrôleur `UserController` avec des méthodes telles que `GetAllUsers`, `GetUserById`, `CreateUser`, `UpdateUser`, `DeleteUser`, etc.

7. Implémentez la logique nécessaire dans chaque méthode de contrôleur pour effectuer les opérations CRUD correspondantes sur votre modèle de données.

8. Testez votre API en utilisant un outil tel que Postman ou Swagger pour envoyer des requêtes HTTP à vos différentes méthodes de contrôleur et vérifier les résultats.

Voilà, vous avez maintenant créé un CRUD API avec .NET 8 en utilisant GitHub Copilot. N'hésitez pas à personnaliser davantage votre API en fonction de vos besoins spécifiques. Bon codage !

- **/DaysBetweenDates**: 

    * calculate days between two dates
    * receive by query string two parameters `date1` and `date2`, and calculate the days between those two dates.

> **_NOTE:_** Use above information inside the Copilot inline feature in the `Program.cs` file. Press enter and wait for Copilot to suggest you the code.

- **/validatephonenumber**: 

    * receive by querystring a parameter called phoneNumber
    * validate phoneNumber with Spanish format, for example `+34666777888`
    * if phoneNumber is valid return true

> **_NOTE:_** Use above information inside a comment in the `Program.cs` file. Press enter and wait for Copilot to suggest you the code.

- **/validatespanishdni**:

    * receive by querystring a parameter called dni
    * calculate DNI letter
    * if DNI is valid return "valid"
    * if DNI is not valid return "invalid"

> **_NOTE:_** Use above information inside a comment in the `Program.cs` file. In this case, you may want to see multiple solutions from Copilot to pick the one that best fits the way to calculate the letter. In order to see the firs 10 suggestions from Copilot press `ctrl + enter`. 

- **/returncolorcode**:

    * receive by querystring a parameter called color
    * read colors.json file and return the rgba field
    * get color var from querystring
    * iterate for each color in colors.json to find the color
    * return the code.hex field

> **_NOTE:_** Lets try Copilot chat now. Paste the above information and make it as detailed as possible in the Copilot chat text box. Copilot will use by default the open file as context in order to generate the suggestion.

- **/tellmeajoke**:

    * Make a call to the joke api and return a random joke

> **_NOTE:_** Here's example where you might need to use you own knowledge and judgement
to validate that Copilot follows best practices. Just because Copilot mimic 
what many developers do, doesn't always mean it's the correct way. You might need 
to be extra specific in your prompt to let Copilot know what's best practices. 
_Hint: Pay attention to HttpClient._
        
- **/moviesbydirector**:

    * Receive by querystring a parameter called director
    * Make a call to the movie api and return a list of movies of that director
    * Return the full list of movies

> **_NOTE:_** This will require to browse to https://www.omdbapi.com/apikey.aspx and request a FREE API Key

- **/parseurl**:

    * Retrieves a parameter from querystring called someurl
    * Parse the url and return the protocol, host, port, path, querystring and hash
    * Return the parsed host

> **_NOTE:_** Copilot can help you learn new frameworks.

- **/listfiles**:

    * Get the current directory
    * Get the list of files in the current directory
    * Return the list of files

> **_NOTE:_** Copilot can also help with these kind of commands locally. The feature is called Copilot in the CLI. You can learn more information about this feature [here](https://docs.github.com/en/copilot/github-copilot-in-the-cli/about-github-copilot-in-the-cli).

- **/calculatememoryconsumption**:

    * Return the memory consumption of the process in GB, rounded to 2 decimals

- **/randomeuropeancountry**:

    * Make an array of european countries and its iso codes
    * Return a random country from the array
    * Return the country and its iso code