using System.Collections.Generic;
using System.Threading.Tasks;
using GCBot.Data.Entities;
using GCBot.Models;

namespace GCBot.Data.Repositories
{
    public interface INoteRepository
    {

        Task InsertNoteAsync(INote note);

        Task DeleteNoteAsync(int id);

        List<INote> SelectNotes(User user);

    }
}