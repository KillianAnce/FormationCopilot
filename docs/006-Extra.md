# GitHub Copilot - Extra
En plus de la génération de code, il permet de simplifier la vie pour de nombreuses tâches comme:
- Mise en place de CI/CD
- Génération de documentation technique avec des outils comme Mermaid
- Génération d'Infrastructure As Code

## Générer la documentation technique
GitHub Copilot permet d'utiliser [Mermaid] (https://mermaid.js.org/) pour publier des diagrammes dans une documentation markdown.

Dans cet exercice le but est d'utiliser GitHub Copilot pour générer :
- Un diagramme de classe
- Un ERD (Entity Relation Diagram) à partir des fichiers SQL

<details>
<summary>Exemple d'utilisation possible</summary>

1. Ouvrez Github Copilot Chat
2. Créer un nouveau chat (avec le bouton `+` en haut de la fenêtre)
3. Utilisez la commande #file, par exemple en demandant ce qui suit `En utilisant les #file:CustomerEntity créez un diagramme de classe avec mermaid`

</details>

## Créer une pipeline AzureDevops
Dans le dossier `cicd` se trouve le fichier `ci.yaml` qui doit répondre aux exigences suivantes : 

- La pipeline CI doit être déclenché par un push vers la branch develop.  
- Il doit construire et restaurer les projets .NET 8  
- Il doit également exécuter les tests et publier les résultats des tests.  
- Enfin, il doit publier l'artefact dans le référentiel d'artefacts.  
- Le pipeline doit pouvoir s'exécuter sur un runner auto-hébergé. 

**Etape supplémentaire :** 
- Rajouter une étape pour construire l'image docker
- Pousser l'image dans un `Azure Container Registry`

## Générer une Infrastructure As Code
Dans le dossier `terraform` se trouve les fichiers `main.tf` et `variable.tf`

- Créer un groupe de resource  
- Créer un virtual network  
- Créer un Network security group  
- Créer un Network interface security group association
- Créer une machine virtuelle

Demander à Copilot :
- Changer le système d'exploitation de votre machine virtuelle
- Changer le SKU de votre machine virtuelle

