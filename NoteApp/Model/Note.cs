using System;

namespace NoteApp.Model {
    public class Note {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }


        public Note(string Id, string Title, string Content, string Category, string State, DateTime Date) {
            this.Id = Id;
            this.Title = Title;
            this.Content = Content;
            this.Category = Category;
            this.State = State;
            this.Date = Date;
        }
    }
}
