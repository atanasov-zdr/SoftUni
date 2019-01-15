﻿public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

public class Dispatcher
{
    private string name;

    public event NameChangeEventHandler NameChange;

    public string Name
    {
        get { return name; }
        set
        {
            OnNameChange(new NameChangeEventArgs(value));
            name = value;
        }
    }
    
    public void OnNameChange(NameChangeEventArgs args)
    {
        if (this.NameChange != null)
        {
            this.NameChange.Invoke(this, args);
        }
    }
}