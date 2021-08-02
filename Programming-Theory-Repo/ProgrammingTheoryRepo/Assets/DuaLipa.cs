using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuaLipa : Singer
{
    public string name = "Dua Lipa";
    public string song = "Levitating";
    public override string ShowName()
    {
        Debug.Log("My name is Bad Dua Lipa");
        return name;
    }

    public override string ShowSong()
    {
        Debug.Log("My song is levitating");
        return song;
    }
}
