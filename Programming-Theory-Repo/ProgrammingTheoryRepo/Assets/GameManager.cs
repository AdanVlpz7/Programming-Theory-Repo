using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text nameTxt;
    public Text songTxt;

    public void SettingDua()
    {
        DuaLipa duaLipa = new DuaLipa();
        nameTxt.text = duaLipa.name;
        songTxt.text = duaLipa.song;
    }

    public void SettingFredy()
    {
        Fredy fredy = new Fredy();
        nameTxt.text = fredy.name;
        songTxt.text = fredy.song;
    }
    public void SettingBadBunny()
    {
        BadBunny badBunny = new BadBunny();
        nameTxt.text = badBunny.name;
        songTxt.text = badBunny.song;
    }
}
