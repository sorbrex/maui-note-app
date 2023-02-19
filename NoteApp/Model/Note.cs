using System;

namespace NoteApp.Model {
    internal class Note {
        private string _category;
        private string _state;
        private DateTime _date;

        //Getter
        public string GetCategory() { return _category; }
        public string GetState() { return _state; }
        public DateTime GetDate() { return _date; }

        //Constructor
        public Note(string State, string Category, DateTime Date) {
            this._category = Category;
            this._state = State;
            this._date = Date; 
        }
    }
}
