using Young_Centre.Model;

namespace Young_Centre.Repository.Account
{
    public interface IAdminAccountService
    {
        Task<StateResponse<Admin>> SignUpAsync(Admin entity);
        Task<StateResponse<Admin>> LogInAsync(string login, string password);

        Task<StateResponse<bool>> DelateAsync(string login, string password);

        Task<StateResponse<bool>> UpdateAsync(int id, Admin entity);
        Task<StateResponse<Admin>> GetByIdAsync(int id);
        Task<StateResponse<IEnumerable<Admin>>> GetAllDataAsync();
    }
}