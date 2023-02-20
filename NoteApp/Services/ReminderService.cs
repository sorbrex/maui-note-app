using System;
using NoteApp.Model;

namespace NoteApp.Services {
    public class ReminderService {
        readonly List<Reminder> reminderList = new();

        public List<Reminder> GetReminder() {
            if (reminderList.Count > 0)
                return reminderList;

            string dateInput = "2023-02-16T10:01:30.1531885+01:00";
            var parsedDate = DateTime.Parse(dateInput);

            for (int i = 0; i < 5; i++) {
                reminderList.Add(new Reminder("ID0" + i, "This is a Custom HardCoded Note", parsedDate));
            }

            return reminderList;

        }
    }
}

