namespace Demo.ManualMapping.DTOs;

public class ClientDTO
{
    public Guid ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, First name: {FirstName}, Last name: {LastName}, Gender: {Gender}";
    }
}