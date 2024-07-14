namespace Entity
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        // Add list of car rentals
        public List<CarRentalEntity>? CarRentals { get; set; }
        
    }
}

//Add entity car and the following proprieties : isRented, startDate, EndDate, and RentalCardId
//Add entity Person and the following proprieties : FirstName, LastName, Email, PhoneNumber, and Address