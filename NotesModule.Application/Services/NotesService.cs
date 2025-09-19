using NotesModule.Application.Interfaces;
using NotesModule.Domain.Entities;
using NotesModule.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesModule.Application.Services
{
    public class NotesService : INotesService
    {
        private readonly INotesRepository _notesRepository;

        public NotesService(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public async Task<IList<NotesModel>> GetAllNotesAsync()
        {
            return await _notesRepository.GetAllAsync();
        }

        public async Task<NotesModel> GetNotesByIdAsync(int id)
        {
            return await _notesRepository.GetByIdAsync(id);
        }

        public async Task AddNotesAsync(NotesModel notesModel)
        {
            await _notesRepository.AddAsync(notesModel);
        }

        public async Task UpdateNotesAsync(NotesModel notesModel)
        {
            await _notesRepository.UpdateAsync(notesModel);
        }

        public async Task DeleteNotesAsync(int id)
        {
            await _notesRepository.DeleteAsync(id);
        }
    }
}
 
