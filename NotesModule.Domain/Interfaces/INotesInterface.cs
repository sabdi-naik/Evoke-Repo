using NotesModule.Domain.Entities;

namespace NotesModule.Domain.Interfaces
{

    public interface INotesRepository
    {
        Task<IList<NotesModel>> GetAllNotesAsync();
        Task<NotesModel> GetNotesByIdAsync(int id);
        Task AddNotesAsync(NotesModel notes);
        Task UpdateNotesAsync(NotesModel notes);
        Task DeleteNotesAsync(int id);

    }
}