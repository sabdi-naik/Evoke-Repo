using Microsoft.EntityFrameworkCore;
using NotesModule.Domain;
using NotesModule.Domain.Entities;
using NotesModule.Domain.Interfaces;

namespace NotesModule.Infrastructure.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private readonly AppDatabaseContext _context;

        public NotesRepository(AppDatabaseContext context)
        {
            _context = context;
        }
        public async Task AddNotesAsync(NotesModel notes)
        {
            _context.Notes.Add(notes);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNotesAsync(int id)
        {
            var notes = await _context.Notes.FindAsync(id);
            if (notes != null)
            {
                notes.IsDeleted = false;
                notes.ModifiedDateTime = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }        

        public async Task<NotesModel> GetNotesByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task UpdateNotesAsync(NotesModel notes)
        {
            _context.Notes.Update(notes);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<NotesModel>>  GetAllNotesAsync()
        {
            return await _context.Notes.OrderByDescending(x => x.CreatedDateTime).
                Where(x => x.IsDeleted == true).ToListAsync();

        }
    }
}
