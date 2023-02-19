namespace NoteApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Registriamo Questa Pagina Come Pagina Di Creazione Note e Assegnamo un "URL" Per Il Routing
        Routing.RegisterRoute("CreateNote", typeof(View.CreateNoteView));
        //Routing.RegisterRoute("NoteApp", typeof(View.NoteAppView));

    }
}
