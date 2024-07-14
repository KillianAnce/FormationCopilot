
namespace Entity
{
    public class CarRentalEntity
    {
        public required CarEntity Car { get; set; }
        public bool IsRented { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RentalCardId { get; set; }
        // Add foreign key
        public required CustomerEntity Person { get; set; }
    }
}

//Add entity car and the following proprieties : isRented, startDate, EndDate, and RentalCardId
//Add entity Person and the following proprieties : FirstName, LastName, Email, PhoneNumber, and Address