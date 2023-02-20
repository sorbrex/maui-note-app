using System;
using System.Collections.ObjectModel;
using NoteApp.Model;
using NoteApp.Services;

namespace NoteApp.ViewModel {
    public class ReminderViewModel : BaseViewModel {
        readonly ReminderService reminderServices = new();
        //Creiamo la proprietà service che servirà per riceve tutti i Reminder salvati nel file

        public Command GetRemindersCommand { get; }
        public Command AddReminderCommand { get; }
        public Command RemoveReminderCommand { get; }


        public ObservableCollection<Reminder> Reminders { get; } = new();

        //Costruttore
        public ReminderViewModel() {
            this.GetRemindersCommand = new Command(() => GetReminders());
            this.AddReminderCommand = new Command(() => AddReminder());
            this.RemoveReminderCommand = new Command(() => RemoveReminder());
        }

        private void GetReminders() {
            List<Reminder> retrievedReminders = reminderServices.GetReminder();

            if (Reminders.Count != 0)
                Reminders.Clear();

            foreach (Reminder singleReminder in retrievedReminders)
                Reminders.Add(singleReminder);
        }

        private void AddReminder() {

        }

        private void RemoveReminder() {

        }

    }
}

