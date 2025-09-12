using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;


public class CardValue :MonoBehaviour
{
    [Header("CardValue")]
    public int cardvalue;
    public int maintype;
    public int blacktype;
    public int graytype;

    [Header("CardPart")]
    public GameObject Cardfront;
    public GameObject Cardback;
    public GameObject Cardresult;
    public Image Blacktypeimage;
    public Image Graytypeimage;
    //public TextMeshProUGUI CardUpValueText;
    //public TextMeshProUGUI CardDownValueText;
    public Image Resultimage;
    public Image Interactableimage;
    public Sprite[] cardicon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        var cardicons = Resources.LoadAll<Sprite>("Icon/CardIcon");
        cardicon = cardicons;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
