namespace SuperHeroApi_DotNet8.Entity
{
    public class SuperHero
    {
        protected SuperHero() { }

        public SuperHero(string name, string firstName, string lastName, string place )
        {
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Place = place;
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
       
    }
}