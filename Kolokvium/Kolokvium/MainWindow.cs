using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Kolokvium.Classes.dbWork dbWork;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        dbWork = new Kolokvium.Classes.dbWork();
        Text.Text = dbWork.ReadFile();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnAddButtonButtonPressEvent(object o, ButtonPressEventArgs args)
    {
        dbWork.Add(Convert.ToInt32(id.Text), Convert.ToInt32(entry3.Text), Convert.ToInt32(entry4.Text), Convert.ToInt32(entry2.Text), Convert.ToInt32(entry5.Text), Convert.ToInt32(entry6.Text), Convert.ToInt32(entry7.Text), Convert.ToInt32(entry8.Text), Convert.ToInt32(entry9.Text));
        Text.Text = dbWork.ReadFile();
    }

    protected void OnDeleteButtonPressEvent(object o, ButtonPressEventArgs args)
    {
        dbWork.Delete(Convert.ToInt32(IDEntry.Text));
        Text.Text = dbWork.ReadFile();
    }
}
