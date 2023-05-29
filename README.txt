NotePad.NET - Pentiminaxt Winform & C# Tutorial

Workflow:
- New Project Windows Forms (.NET Framework)
- Form1 StartPosition property to CenterScreen
- Renamed Form1.cs to MainForm.cs
- MainForm Property Text to NotePad.NET
- Added new folder Controls to the project
- Added new class MainMenuStrip.cs in folder Controls
- This class inherits for MenuStrip from System.Windows.Forms
- MainMenuStrip Constructor
		- Name property (Name="MainMenuStrip")
		- Dock Property to Top (Dock = DockStyle.Top)
- Dans notre MainForm.cs, on instancie une nouvel objet de notre classe MainMenuStrip (donc appel du constructeur)
- Cet objet (qui est un controle) na pas encore été ajouté à notre Form.
	-> On utilise la propriété Controls de notre Classe MainForm (qui herite de Form), qui est la liste des controls
		de notre form. Donc on peux lui ajouter un controle avec la méthode Add:
		this.Controls.Add(_mainMenuStrip)
- Dans notre classe MainMenuStrip, on instancie un objet ToolStripMenuItem pour créer les menus cliquables.
	-> Et comme pour notre form, il faut maintenant ajouter l'Item à notre MenuStrip
	-> this.Items.add(fileMenu);