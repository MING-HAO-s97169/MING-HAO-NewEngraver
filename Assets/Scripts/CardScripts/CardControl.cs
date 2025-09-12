using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class CardControl : MonoBehaviour
{
    private enum Cardfrontorback
    {
        Front,
        Back
    }
    private Cardfrontorback cardfrontorback;
    public GameObject cardfront;
    public GameObject cardback;
    private bool isChangecard;
    private float changespeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
