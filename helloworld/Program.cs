using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
public static class Program
{

    public class Employee
    {
        // TODO : Ajoutez les propriétés nécessaires pour représenter un employé ( Nom, Prenom, Email, DateEntreeEntreprise, TempsTravailHebdomadaire )
    }

    public static void Main()
    {
        string CsvPath = "./employees.csv";

        // TODO : Implémenter une fonction pour calculer une factorielle

        // TODO: Lire les employés depuis le fichier CSV et les stocker dans une liste

        // TODO: Afficher les employés et vérifier si les emails sont valides

        // TODO: Trier les employés par date d'entrée dans l'entreprise

        // TODO: Afficher les employés triés par date d'entrée

        // TODO: Convertir le temps de travail hebdomadaire au format classique et afficher

    }

    // Fonction pour calculer une factorielle

    // Fonction pour lire les employés depuis un fichier CSV
    private static List<Employee> ReadEmployeesFromCsv(string csvPath)
    {
        // TODO: Implémentez cette méthode pour lire les données d'employés depuis un fichier CSV et les retourner sous forme de liste d'objets Employee
        return new List<Employee>();
    }

    // Fonction pour trier les employés par date d'entrée dans l'entreprise
    private static void SortEmployeesByDate(List<Employee> employees)
    {
        // TODO: Implémentez cette méthode pour trier la liste des employés par leur date d'entrée dans l'entreprise
    }

    // Fonction pour convertir le temps de travail hebdomadaire au format classique (hh:mm)
    private static string ConvertToClassicFormat(double tempsTravailHebdomadaire)
    {
        // TODO: Implémentez cette méthode pour convertir un double représentant le temps de travail hebdomadaire en une chaîne de caractères au format hh:mm
        return "";
    }

    // Fonction pour valider une adresse email en utilisant une expression régulière
    public static bool IsValidEmail(string email)
    {
        // TODO: Implémentez cette méthode pour valider une adresse email en utilisant une expression régulière et retourner vrai ou faux
        return false;
    }

    

}
