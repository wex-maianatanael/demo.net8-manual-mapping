using Demo.ManualMapping.DTOs;
using Demo.ManualMapping.Mapping;
using Demo.ManualMapping.ViewModels;

Console.Write("First name: ");
var firstName = Console.ReadLine();

Console.Write("Last name: ");
var lastName = Console.ReadLine();

Console.Write("Gender (m - male | f - female | o - other): ");
char gender = char.Parse(Console.ReadLine());

ClientViewModel clientVm = new();
clientVm.FirstName = firstName;
clientVm.LastName = lastName;
clientVm.Gender = gender;

ClientDTO response = ViewModelToDto.MapToClientDTO(clientVm);

Console.Write($"Mapping Result: {response}");