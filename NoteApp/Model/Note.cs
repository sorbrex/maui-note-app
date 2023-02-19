using System;

namespace NoteApp.Model {
    public class Note {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }

    }
}
