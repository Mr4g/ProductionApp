namespace ProductionApp.Entities
{
    public class EntityBase : IEntity
    {
        public string? Name { get; set; }   
        public int Id { get; set; }
    }
}
