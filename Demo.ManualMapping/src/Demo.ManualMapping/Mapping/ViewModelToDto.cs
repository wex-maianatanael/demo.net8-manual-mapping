using Demo.ManualMapping.ViewModels;
using Demo.ManualMapping.DTOs;

namespace Demo.ManualMapping.Mapping;

public static class ViewModelToDto
{
    public static ClientDTO MapToClientDTO(this ClientViewModel client)
    {
        return new ClientDTO
        {
            ID = client.ID,
            FirstName = client.FirstName,
            LastName = client.LastName,
            Gender = client.Gender
        };
    }
}