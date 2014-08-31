namespace NestedViewModelsInMVC.Models
{
    public class Person
    {
        public Person()
        {
            Addr = new Address();
        }

        public string Name { get; set; }
        public Address Addr { get; set; }
    }
}