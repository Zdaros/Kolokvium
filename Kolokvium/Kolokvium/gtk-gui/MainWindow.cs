
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action Action;

	private global::Gtk.Action Action1;

	private global::Gtk.Action Action2;

	private global::Gtk.Action Action5;

	private global::Gtk.Action Action4;

	private global::Gtk.Action Action18;

	private global::Gtk.Action Action7;

	private global::Gtk.Action Action8;

	private global::Gtk.Action Action12;

	private global::Gtk.Action Action10;

	private global::Gtk.Action Action11;

	private global::Gtk.Action Action13;

	private global::Gtk.Action Action14;

	private global::Gtk.Action Action15;

	private global::Gtk.Action Action16;

	private global::Gtk.Action SO2Action;

	private global::Gtk.Action Action17;

	private global::Gtk.Action HCIAction;

	private global::Gtk.VBox Manu;

	private global::Gtk.VBox vbox4;

	private global::Gtk.HSeparator hseparator5;

	private global::Gtk.HBox Menu;

	private global::Gtk.Button AddButton;

	private global::Gtk.Button Delete;

	private global::Gtk.HBox Search;

	private global::Gtk.Entry DeleteEntry;

	private global::Gtk.Button Redact;

	private global::Gtk.HSeparator hseparator3;

	private global::Gtk.Label Taxt;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.Action = new global::Gtk.Action("Action", global::Mono.Unix.Catalog.GetString("Всі"), null, null);
		this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString("Місто");
		w1.Add(this.Action, null);
		this.Action1 = new global::Gtk.Action("Action1", null, null, null);
		w1.Add(this.Action1, null);
		this.Action2 = new global::Gtk.Action("Action2", global::Mono.Unix.Catalog.GetString("Область"), null, null);
		this.Action2.ShortLabel = global::Mono.Unix.Catalog.GetString("Область");
		w1.Add(this.Action2, null);
		this.Action5 = new global::Gtk.Action("Action5", global::Mono.Unix.Catalog.GetString("Місто"), null, null);
		this.Action5.ShortLabel = global::Mono.Unix.Catalog.GetString("Місто");
		w1.Add(this.Action5, null);
		this.Action4 = new global::Gtk.Action("Action4", null, null, null);
		w1.Add(this.Action4, null);
		this.Action18 = new global::Gtk.Action("Action18", global::Mono.Unix.Catalog.GetString("Вибір по чому шукати"), null, null);
		this.Action18.ShortLabel = global::Mono.Unix.Catalog.GetString("Вибір по чому шукати");
		w1.Add(this.Action18, null);
		this.Action7 = new global::Gtk.Action("Action7", global::Mono.Unix.Catalog.GetString("Все"), null, null);
		this.Action7.ShortLabel = global::Mono.Unix.Catalog.GetString("Все");
		w1.Add(this.Action7, null);
		this.Action8 = new global::Gtk.Action("Action8", global::Mono.Unix.Catalog.GetString("Область"), null, null);
		this.Action8.ShortLabel = global::Mono.Unix.Catalog.GetString("Область");
		w1.Add(this.Action8, null);
		this.Action12 = new global::Gtk.Action("Action12", global::Mono.Unix.Catalog.GetString("Населений пункт"), null, null);
		this.Action12.ShortLabel = global::Mono.Unix.Catalog.GetString("Населений пункт");
		w1.Add(this.Action12, null);
		this.Action10 = new global::Gtk.Action("Action10", global::Mono.Unix.Catalog.GetString("Код Області"), null, null);
		this.Action10.ShortLabel = global::Mono.Unix.Catalog.GetString("Код Області");
		w1.Add(this.Action10, null);
		this.Action11 = new global::Gtk.Action("Action11", global::Mono.Unix.Catalog.GetString("Код Населеного пункту"), null, null);
		this.Action11.ShortLabel = global::Mono.Unix.Catalog.GetString("Код Населеного пункту");
		w1.Add(this.Action11, null);
		this.Action13 = new global::Gtk.Action("Action13", global::Mono.Unix.Catalog.GetString("Геморфологічна прив\'язка місця відбору проби"), null, null);
		this.Action13.ShortLabel = global::Mono.Unix.Catalog.GetString("Геморфологічна прив\'язка місця відбору проби");
		w1.Add(this.Action13, null);
		this.Action14 = new global::Gtk.Action("Action14", global::Mono.Unix.Catalog.GetString("дата відбору (Д/М/Р)"), null, null);
		this.Action14.ShortLabel = global::Mono.Unix.Catalog.GetString("дата відбору (Д/М/Р)");
		w1.Add(this.Action14, null);
		this.Action15 = new global::Gtk.Action("Action15", global::Mono.Unix.Catalog.GetString("Вуглекислий газ"), null, null);
		this.Action15.ShortLabel = global::Mono.Unix.Catalog.GetString("Вуглекислий газ");
		w1.Add(this.Action15, null);
		this.Action16 = new global::Gtk.Action("Action16", global::Mono.Unix.Catalog.GetString("СО"), null, null);
		this.Action16.ShortLabel = global::Mono.Unix.Catalog.GetString("СО");
		w1.Add(this.Action16, null);
		this.SO2Action = new global::Gtk.Action("SO2Action", global::Mono.Unix.Catalog.GetString(" SO2"), null, null);
		this.SO2Action.ShortLabel = global::Mono.Unix.Catalog.GetString(" SO2");
		w1.Add(this.SO2Action, null);
		this.Action17 = new global::Gtk.Action("Action17", global::Mono.Unix.Catalog.GetString("Бензин"), null, null);
		this.Action17.ShortLabel = global::Mono.Unix.Catalog.GetString("Бензин");
		w1.Add(this.Action17, null);
		this.HCIAction = new global::Gtk.Action("HCIAction", global::Mono.Unix.Catalog.GetString("HCI"), null, null);
		this.HCIAction.ShortLabel = global::Mono.Unix.Catalog.GetString("HCI");
		w1.Add(this.HCIAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.Manu = new global::Gtk.VBox();
		this.Manu.Name = "Manu";
		this.Manu.Spacing = 6;
		// Container child Manu.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hseparator5 = new global::Gtk.HSeparator();
		this.hseparator5.Name = "hseparator5";
		this.vbox4.Add(this.hseparator5);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator5]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.Menu = new global::Gtk.HBox();
		this.Menu.Name = "Menu";
		this.Menu.Spacing = 6;
		// Container child Menu.Gtk.Box+BoxChild
		this.AddButton = new global::Gtk.Button();
		this.AddButton.CanFocus = true;
		this.AddButton.Name = "AddButton";
		this.AddButton.UseUnderline = true;
		this.AddButton.Label = global::Mono.Unix.Catalog.GetString("Добавити");
		this.Menu.Add(this.AddButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.Menu[this.AddButton]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child Menu.Gtk.Box+BoxChild
		this.Delete = new global::Gtk.Button();
		this.Delete.CanFocus = true;
		this.Delete.Name = "Delete";
		this.Delete.UseUnderline = true;
		this.Delete.Label = global::Mono.Unix.Catalog.GetString("Видалити");
		this.Menu.Add(this.Delete);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.Menu[this.Delete]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child Menu.Gtk.Box+BoxChild
		this.Search = new global::Gtk.HBox();
		this.Search.Name = "Search";
		this.Search.Spacing = 6;
		// Container child Search.Gtk.Box+BoxChild
		this.DeleteEntry = new global::Gtk.Entry();
		this.DeleteEntry.CanFocus = true;
		this.DeleteEntry.Name = "DeleteEntry";
		this.DeleteEntry.IsEditable = true;
		this.DeleteEntry.InvisibleChar = '●';
		this.Search.Add(this.DeleteEntry);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.Search[this.DeleteEntry]));
		w5.Position = 0;
		// Container child Search.Gtk.Box+BoxChild
		this.Redact = new global::Gtk.Button();
		this.Redact.CanFocus = true;
		this.Redact.Name = "Redact";
		this.Redact.UseUnderline = true;
		this.Redact.Label = global::Mono.Unix.Catalog.GetString(" Редагувати");
		this.Search.Add(this.Redact);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.Search[this.Redact]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		this.Menu.Add(this.Search);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.Menu[this.Search]));
		w7.Position = 2;
		this.vbox4.Add(this.Menu);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.Menu]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.Name = "hseparator3";
		this.vbox4.Add(this.hseparator3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator3]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.Manu.Add(this.vbox4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.Manu[this.vbox4]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child Manu.Gtk.Box+BoxChild
		this.Taxt = new global::Gtk.Label();
		this.Taxt.Name = "Taxt";
		this.Taxt.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
		this.Manu.Add(this.Taxt);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.Manu[this.Taxt]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.Add(this.Manu);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 781;
		this.DefaultHeight = 617;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
