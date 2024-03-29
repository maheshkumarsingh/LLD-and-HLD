namespace Entities
{
    /// <summary>
    /// Country Domain model
    /// </summary>
    public class Country
    {
        private Guid _id;
        private string? _name;

        public Guid CountryID { get => Guid.NewGuid(); set => _id = value; }
        public string? CountryName { get => _name; set => _name = value; }
    }
}
