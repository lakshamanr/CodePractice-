namespace RazorApplication.Data
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } 
    }
}
