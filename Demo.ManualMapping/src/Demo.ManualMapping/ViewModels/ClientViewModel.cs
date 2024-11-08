namespace Demo.ManualMapping.ViewModels;

public class ClientViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
}