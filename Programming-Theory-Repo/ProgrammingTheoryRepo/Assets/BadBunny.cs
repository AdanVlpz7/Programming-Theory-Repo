using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadBunny : Singer
{
    public string name = "Bad Bunny";
    public string song = "25/8";
    public override string ShowName()
    {
        Debug.Log("My name is Bad Bunny");
        return name;
    }

    public override string ShowSong()
    {
        Debug.Log("My song is 25/8");
        return song;
    }
}
