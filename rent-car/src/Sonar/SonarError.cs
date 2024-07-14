using System;
using System.Linq;
using System.Security.Cryptography;

namespace Sonar
{
    public class SonarError
    {
        // Erreur Sonar : "Possible division by zero" (S3518)
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        // Erreur Sonar : "Replace this hardcoded string with the actual value from a resource." (S1075)
        public string GetStringFromResource(string resourceName)
        {
            // Replace this with your logic to retrieve the string from a resource file or database
            return "Replace this hardcoded string with the actual value from a resource.";
        }

        // Erreur Sonar : "Use a stronger algorithm than MD5" (S2070)
        public void EncryptData(string data)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
            }
        }

        // Erreur Sonar : "Inefficient use of LINQ method" (S2971)
        public int GetSumOfEvenNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            return evenNumbers.Sum();
        }

        // Erreur Sonar : "Objects should be disposed more than once" (S2930)
        public void ReadFile(string filePath)
        {
            var reader = new StreamReader(filePath);
            var content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        // Erreur Sonar : "Remove this commented out code" (S125)
        public void ProcessData()
        {
            // This method processes the data
            // and stores it in the database.
            // Removed unnecessary logic.
            int result = 0;
            // some complex logic
            result += 10;
        }

        // Erreur Sonar : "Return values should not be ignored when function calls do not have side effects" (S2201)
        public void SaveData(string data)
        {
            File.WriteAllText("data.txt", data);
        }

        // Erreur Sonar : "SQL queries should not be vulnerable to injection attacks" (S3649)
        public void GetUserByUsername(string username)
        {
            string query = $"SELECT * FROM Users WHERE Username = '{username}'";
            // Execute query
        }
    }
}