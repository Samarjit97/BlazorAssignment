using BlazorAssignment.Models;

namespace BlazorAssignment.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}