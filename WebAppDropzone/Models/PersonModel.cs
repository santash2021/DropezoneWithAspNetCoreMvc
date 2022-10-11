namespace WebAppDropzone.Models;

public class PersonModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<PersonDataModel>? PersonDataModels { get; set; }
}

public class PersonDataModel
{
    public string? ProductName { get; set; }
    public IFormFileCollection? Files { get; set; }
}