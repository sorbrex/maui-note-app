using System;
using System.Collections.ObjectModel;
using NoteApp.Model;
using NoteApp.Services;

namespace NoteApp.ViewModel {
    public class NoteViewModel : BaseViewModel {
        readonly NoteService noteServices = new();
        //Creiamo la proprietà service che servirà per riceve tutte le note salvate nel file

        public Command GetNotesCommand { get; }
        //Adesso che usiamo l'MVVM dobbiamo usare i Command per triggerare gli eventi ed eseguire pezzi di codice.
        //Maggiori Informazioni Qui => https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/commanding?view=net-maui-7.0
        public Command AddNoteCommand { get; }
        public Command RemoveNoteCommand { get; }

        public ObservableCollection<Note> Notes { get; } = new();
        //Fondamentale ricordarsi che per poterle interfacciare con la UI devono essere dichiarate come proprietà ({ get; set;}) e devono essere public
        //Le ObservableCollection sono Collection che hanno INotifyPropertyChanged integrate, questo significa che questa proprietà può essere osservata direttamente dallo XAML della View.
        //In questo modo ogni volta che Aggiungiamo o Rimuoviamo un elemento dalla collectio, la UI verrà informata senza bisogno di altre istruzioni.

        //Costruttore
        public NoteViewModel() {
            this.GetNotesCommand = new Command(() => GetNotes()); //Specifichiamo l'azione del comando, ossia chiamare una funzione interna che carica le Notes
            this.AddNoteCommand = new Command(() => AddNote());
            this.RemoveNoteCommand = new Command(() => RemoveNote());
        }
    

        //Inizializziamo la lista di Note utilizzando il noteService che legge il file e lo serializza
        public void GetNotes() {
            List<Note> retrievedNotes = noteServices.GetNotes();

            if (Notes.Count != 0)
                Notes.Clear();

            foreach (Note singleNote in retrievedNotes)
                Notes.Add(singleNote);
        }


        private void AddNote() {

        }

        private void RemoveNote() {

        }

    }
}

