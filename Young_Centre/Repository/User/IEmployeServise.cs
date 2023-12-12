using Young_Centre.Model;

namespace Young_Centre.Repository.User
{
    public interface IEmployeServise
    {

        Task<StateResponse<bool>> DeletAsync(string name, bool employee);
        Task<StateResponse<bool>> UpdateAsync(int id, Employe employe);
        Task<StateResponse<IEnumerable<Admin>>> GetAllDataAsync();
        Task<StateResponse<Employe>> SignUpAsync(Employe employe);

    }
}