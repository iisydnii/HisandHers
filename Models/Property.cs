namespace HisandHers.Models
{
    public class Property
    {
        public int id { get; set; }

        public int customerId { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zip { get; set; }

        public int sqrft { get; set; }
    }
}
