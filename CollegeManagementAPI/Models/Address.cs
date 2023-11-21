namespace CollegeManagementAPI.Models
{
    public class Address
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public Address(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
    }
}
