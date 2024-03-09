public class SuperHeroInputModel
{
    protected SuperHeroInputModel() { }

    public SuperHeroInputModel(string name, string firstName, string lastName, string place)
    {
        Name = name;
        FirstName = firstName;
        LastName = lastName;
        Place = place;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Place { get; set; }

}