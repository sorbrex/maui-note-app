namespace NoteApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Registriamo Questa Pagina Come Pagina Di Creazione Note e Assegnamo un "URL" Per Il Routing
        Routing.RegisterRoute("CreateNote", typeof(View.CreateNotePage));
        Routing.RegisterRoute("NoteApp", typeof(View.NoteAppPage));

    }
}
