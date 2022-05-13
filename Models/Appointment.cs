namespace HisandHers.Models
{
    public class Appointment
    {
        public int id { get; set; }

        public int customerId { get; set; }

        public int employeeId { get; set; }

        public int propertyId { get; set; }

        public string appointmentType { get; set; }

        public string propertyType { get; set; }

        public string appointmentDate { get; set; }

        public string appointmentTime { get; set; }

        public decimal price { get; set; }

        public decimal timespent { get; set; }

        public string notes { get; set; }

        public int rating { get; set; }
    }
}
