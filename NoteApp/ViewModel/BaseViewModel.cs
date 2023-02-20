using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NoteApp.ViewModel {
    //Questa classe è quella di base per i ViewModel.
    //Ogni view model dovrebbe implementare INotifyPropertyChanged, e di conseguenza definire la proprietà evento che segnala il cambiamento di una proprietà
    //In questo modo invice (come vedremo sotto) definiamo solo una volta la funzione che si occupa di notificare la modifica della proprietà
    //Ogni altro ViewModel estenderà poi questa classe e si troverà di conseguenza il metodo già definito.
    public class BaseViewModel : INotifyPropertyChanged {
        //Definiamo la Proprietà Evento per Conformarci con INotifyPropertyChanged
        //Questo evento dovrà essere chiamato ogni volta che una proprietà cambia per aggiornare l'interfaccia
        public event PropertyChangedEventHandler PropertyChanged;

        //Invece di invocare direttamente l'evento PropertyChanged, useremo questo metodo.
        //Nello specifico "name" indica il nome della proprietà che viene cambiata nel nostro ViewModel (uno di quelli che estenderà questa classe)
        //Utilizzando CallerMemberName non dobbiamo preoccuparci di settare noi il contenuto di name
        //Sostanzialmente chiameremo l'evento sulla proprietà e invece di passare anche il nome, lui ricaverà il nome automaticamente poiché il nome è equivalente al caller (ossia alla proprietà)
        //In seguito in PropertyChanged? utilizziamo il ? per assicurarci che la proprietà non è nulla prima di chiamare il metodo
        //Sull'evento chiamiamo quindi l'Invoke con this e con un nuovo evento di cambiamento (passando la proprietà cambiata)
        //In questo modo abbiamo un metodo generico da chiamare quando viene modificata una proprietà
        //Un metodo che appunto comunicherà all'interfaccia (view) di aggiornarsi perché il dato è cambiato
        public void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        
    }
}

