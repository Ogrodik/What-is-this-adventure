using System;
using UnityEngine;

public class SaveScript : MonoBehaviour
{
    public void SaveStat(string nameStat)
    {
        PlayerPrefs.SetInt(nameStat, 1);
    }

    public bool LoadStat(string nameStat)
    {
        if(PlayerPrefs.HasKey(nameStat))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
