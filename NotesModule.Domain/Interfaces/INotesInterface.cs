using NotesModule.Domain.Entities;

namespace NotesModule.Domain.Interfaces
{

    public interface INotesRepository
    {
        Task<IList<NotesModel>> GetAllAsync();
        Task<NotesModel> GetByIdAsync(int id);
        Task AddAsync(NotesModel notes);
        Task UpdateAsync(NotesModel notes);
        Task DeleteAsync(int id);

    }
}