using System;

namespace NoteApp.Model {
    public class Reminder {

        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


        public Reminder(string Id, string Content, DateTime Date) {
            this.Id = Id;
            this.Content = Content;
            this.Date = Date;
        }
    }
}
