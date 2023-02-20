using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using NoteApp.Model;

namespace NoteApp.Services {
    //Questa classe ci serve per leggere tutte le note all'interno del file XML => Non più visto che non funziona quindi serve ad hardcodarle
    //Volendo sarà consigliabile creare un altro service per i Reminder, che farà la stessa cosa ma con Reminders al posto di Notes e con la Classe specifica (da creare dentro Models)
    public class NoteService {
        readonly List<Note> notesList = new();

        public List<Note> GetNotes() {
            if (notesList.Count > 0)
                return notesList;

            string dateInput = "16/02/2023 10:01:30";
            var parsedDate = DateTime.Parse(dateInput);

            for (int i = 0; i < 5; i++) {
                notesList.Add(new Note("ID0"+i, "Custom Title", "This is a Custom HardCoded Note", "Random Test", "Active", parsedDate));
            }

            return notesList;



            //Giusto per Info questo è il pezzo che non funzionava
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Note>));      <==    L'Applicazione Crashava Qui
            //using var stream = File.OpenRead(filePath);
            //List<Note> dezerializedList = (List<Note>)serializer.Deserialize(stream);
            //notesList = dezerializedList;

        }
    }
}

