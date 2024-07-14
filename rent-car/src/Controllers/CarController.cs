using Microsoft.AspNetCore.Mvc;

namespace Controllers;
[Route("[controller]")]
public class CarController : ControllerBase
{
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }
    // Use the CarService to implement the following actions
    // Liste des voitures
    // Liste des voitures par id
    // Supprimer une voiture
    // Mettre à jour une voiture
    // Liste des voitures par couleur
    // Liste des voitures par marque
    // Liste des voitures par modèle
    // Liste des voitures par année
    // Liste des voitures disponibles
    // Liste des voitures ayant moins de 1000 km
    // Liste des voitures rouges
    

}

