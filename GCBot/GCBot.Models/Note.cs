using System;

namespace GCBot.Models
{
    public class Note : INote 
    {

        public Note(ulong userId, string description, ulong createdBy, DateTime date, Enums.NoteTypes type)
        {
            UserId = userId;
            Description = description;
            CreatedBy = createdBy;
            Date = date;
            Type = type;
        }

        public ulong UserId { get; }

        public string Description { get; }

        public ulong CreatedBy { get; }
        
        public DateTime Date { get; }

        public Enums.NoteTypes Type { get; set; }
    }
}
