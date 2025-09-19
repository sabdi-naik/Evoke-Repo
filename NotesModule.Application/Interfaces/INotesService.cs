using NotesModule.Domain.Entities;
 

namespace NotesModule.Application.Interfaces
{
    public interface INotesService
    {
        Task<IList<NotesModel>> GetAllNotesAsync();
        Task<NotesModel> GetNotesByIdAsync(int id);
        Task AddNotesAsync(NotesModel notes);
        Task UpdateNotesAsync(NotesModel notes);
        Task DeleteNotesAsync(int id);
    }
}
