using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fredy : Singer
{
    public string name = "Fredy Mercury";
    public string song = "Don´t stop me now";
    public override string ShowName()
    {
        Debug.Log("My name is Fredy Mercury");
        return name;
    }

    public override string ShowSong()
    {
        Debug.Log("My song is Don´t stop me now");
        return song;
    }
}
