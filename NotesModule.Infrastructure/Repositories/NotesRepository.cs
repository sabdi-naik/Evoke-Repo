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
        public async Task AddAsync(NotesModel notes)
        {
            _context.Notes.Add(notes);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Notes.FindAsync(id);
            if (product != null)
            {
                _context.Notes.Remove(product);
                await _context.SaveChangesAsync();
            }
        }        

        public async Task<NotesModel> GetByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task UpdateAsync(NotesModel notes)
        {
            _context.Notes.Update(notes);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<NotesModel>>  GetAllAsync()
        {
            return await _context.Notes.OrderByDescending(x => x.CreatedDateTime).
                Where(x => x.IsDeleted == true).ToListAsync();

        }
    }
}
