## Génération de tests
Nous allons créer des tests automatisés pour vérifier que la fonctionnalité des endpoints crées et de tester la logique des services associés.

Il existe une commande /tests que vous pouvez exécuter directement à partir de Copilot Chat ou en sélectionnant le morceau de code pour lequel vous voulez créer des tests et en utilisant la fonction inline de Copilot.

Vous pouvez utiliser Copilot pour exécuter les tests.

# Instructions
**Nous utiliserons Xunit pour définir nos plans de tests.**  
 Si certaines personnes veulent utiliser Nunit à la place, il suffit de le rajouter à la solution :  
``` 
CTRL+SHIFT+P -> .NET : Nouveau projet -> Nunit
```

Il existe 2 fichiers de tests dans le répertoire `/test` :
- `UnitTest.cs` pour la définition de tests unitaires sur la couche services contenant la logique métier  
  - Utiliser AutoFixture pour générer des données.
- `IntegrationTest.cs` pour la définition de tests d'intégration sur les différents endpoints que vous avez défini.
  - Mettez en place les TI en utilisant les librairies Fixture & NSubsitute ou MoQ

Pour lancer les tests, vous avez plusieurs options : 
- Se positionner dans votre CLI sur le dossier `rent-car/test` 
  - Saisir `dotnet test`
- Utiliser la commande `make test` définis dans le fichier Makefile