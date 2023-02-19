namespace NoteApp;

//Anche qui Abbiamo due file, uno dedicato all'interfaccia e alla costruzione della UI,
//e un altro dedicato alla logica dietro la pagina (probabilmente questa cosa cambia nel mvvm)
//In questo caso stiamo dicendo che la classe MainPage contiene una proprietà counter ed un metodo per modificarla
//Il metodo che modifica la proprietà counter viene chiamato dal bottone (UI - onClick)
//Questo metodo aggiunge uno al contatore e lo setta come testo nel bottone.

public partial class MainPage : ContentPage {
	private int _count = 0;

	public MainPage() {
		InitializeComponent();
	}
	
	//Spoiler: Si può usare la keyword override per utilizzare metodi di sistema
	//Ad esempio si può usare 
	//		private override void OnAppearing() { faiCoseBelle() }
	//Per dire al sistema di eseguire instruzioni quando viene visualizzata questa interfaccia
	//Altri metodi simili possono essere utilizzati in App -> Vedi file
	private void OnPlusClick ( object sender, EventArgs e) {
		_count++;
		CounterLabel.Text = $"Counter Reached: {_count}";

		//SemanticScreenReader.Announce(CounterLabel.Text); -> Questa è una cosa di accessibilità, tipo per i non vedenti.
		//Ogni volta che cambiamo la proprietà annunciamo il nuovo messaggio che è stato settato nel Counter Button.
	}


    private void OnMinusClick ( object sender, EventArgs e ) {
        _count--;
		CounterLabel.Text = $"Counter Reached: {_count}";
    }

    private void ShowPopup ( object sender, EventArgs e ) {
		DisplayAlert("Alert", "This is an alert", "OK");
    }

    private async void GoToNewNote ( object sender, EventArgs e ) {
        await Shell.Current.GoToAsync("CreateNote"); //Possiamo passare anche query params con "CreateNote?id=IS93"
		//Se vogliamo creare un pulsante per tornare indietro, scriveremo "await Shell.Current.GoToAsync("..");"
    }
    

}

