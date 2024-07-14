# Créer un CRUD API en .NET 8

## Contexte 
Un couple en vacances en Provence souhaite louer une voiture pour explorer les villages pittoresques et les paysages magnifiques de la région. Ils recherchent un véhicule confortable et économique pour une durée de cinq jours.

Un couple se rend à l'agence de location de voitures VoyageAuto, dont le slogan est "Profitez de vos vacances au maximum". Ils souhaitent choisir parmi un panel de véhicules disponibles pour explorer la région en toute liberté et confort pendant leur séjour.

## Exercice
Pour lancer le projet, vous avez plusieurs options : 
- Utiliser les commandes suivantes : `make init-project` avant la première exécution et `make launch`
- Se rendre dans le dossier `rent-car/src` et lancer `dotnet run`

### Création des entités
Se rendre dans le dossier `Entity`
Les consignes sont présentes dans chacun des fichiers sur ce qui est nécessaire à de créer.

Vous allez devoir créer les entités suivantes :
- Car
- Customer
- CarRental

Il faut aussi setup votre DBContext dans le fichier `RentCarDbContext.cs`.

Se rendre dans `Program.cs` pour ajouter une base inmemory en utilisant le **RentCarDbContext**

### Création du repository 
Vous avez créer les entités, on va passer à l'étape suivante qui est de créer la partie respository qui permet d'accéder à la BDD.
Se rendre dans le dossier `Repositories`
- Créer les actions nécessaires dans `CarRepository.cs`  
  - Il n'est pas nécessaire de créer toutes les actions

#### Extra : 
Si vous avez du temps, vous pouvez vous amuser à faire les repositories `Customer` & `CarRental`
Comme d'habitude, les consignes se trouvent dans les fichiers.

### Création du service Car
Vous venez de créer la partie qui fait le lien avec la BDD, il est temps de mettre en place la partie logique métier.
Rendez-vous dans le dossier `Services`
- Créer les méthodes définies en commentaire

#### Bonus : 
Si vous avez du temps, vous pouvez vous amuser à faire les services `Customer` & `CarRental`
Comme d'habitude, les consignes se trouvent dans les fichiers.

### Création des controllers
Vous venez de créer la partie logique métier, il est temps de mettre en place les endpoints pour accéder à ces données.

Rendez-vous dans le dossier `Controllers`
- Créer les différents endpoints définis en commentaire

#### Bonus
Si vous avez du temps, vous pouvez vous amuser à faire les controllers `Customer` & `CarRental`
Comme d'habitude, les consignes se trouvent dans les fichiers.

## Exercice bonus
Création des endpoints suivant dans le fichier `TestController.cs`

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