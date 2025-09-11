using UnityEngine;
using System.Collections.Generic;

public abstract class ICardSetting:MonoBehaviour
{
    public int cardvalue;
    public int maintype;
    public int blacktype;
    public int graytype;
    public Sprite[] cardicon;

    public void SettingValue()
    {
        var cardicons = Resources.LoadAll<Sprite>("Icon/CardIcon");
        cardicon = cardicons;
    }
    void Update()
    {
        
    }
}
