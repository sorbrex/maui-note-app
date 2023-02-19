namespace NoteApp;

//Questo è lo startup point.
//Quando viene eseguita l'applicazione questo è il primo codice che viene caricato e si occupa di inizzializzare tutto.
//In questo caso vediamo che inizzializza il builder passando la App e i due font predefiniti

//In particolare "Utilizzarà il file App.xaml", che a sua volta chiamerà il file App.xaml.xs
//Il primo si occupa di dichiarare le dipendenze dell'applicazione (es. Resources/Style)
//Il secondo si occupa di inizializzare i componenti e di Inizializzare AppShell.
//AppShell difisce il contenuto dell'applicazione e le pagine
/*
     <ShellContent
        Title="Home" -> Titolo Pagina
        ContentTemplate="{DataTemplate local:MainPage}" -> File che contiene la UI (Vai al file per altre info)
        Route="MainPage" />  -> Route per Accedere alla Pagina
 */
public static class MauiProgram {
	public static MauiApp CreateMauiApp() {
		
		var builder = MauiApp.CreateBuilder();
		
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
