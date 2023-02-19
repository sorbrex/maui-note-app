namespace NoteApp;

public partial class App : Application {
	public App() {
		InitializeComponent();

		MainPage = new AppShell();
	}
	
	//Spoiler: Override keyword. Se lo stai vedendo per la prima volta passa prima a leggere MainPage.xaml.cs
	/* Alcuni esempi di Override possono essere i seguenti
	protected override void OnChildAdded(Element child) {
		base.OnChildAdded(child);
	}

	public override void CloseWindow(Window window) {
		base.CloseWindow(window);
	}
	*/
}
