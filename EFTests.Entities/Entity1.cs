namespace EFTests.Entities
{
    public class Entity1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Entity2Id { get; set; }
        public Entity2 Entity2 { get; set; }
    }
}