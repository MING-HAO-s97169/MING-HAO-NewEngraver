using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using DG.Tweening;

public class CardControl : MonoBehaviour
{
    private enum Cardflip
    {
        front,
        back
    }
    public GameObject cardfront;
    public GameObject cardback;
    private bool isChangecard;
    private float changespeed = 0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(Flipfront());
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(Flipback());
        }
    }
    private IEnumerator Flipfront()
    {
        cardback.transform.DORotate(new Vector3(0, 90, 0), changespeed);
        for (float speed = changespeed; speed > 0; speed -= Time.deltaTime)
        {
           yield return 0;
        }
        cardfront.SetActive(true);
        cardfront.transform.DORotate(new Vector3(0, 0, 0), changespeed);
        cardback.SetActive(false);
    }
    private IEnumerator Flipback()
    {
        cardfront.transform.DORotate(new Vector3(0, 90, 0), changespeed);
        for (float speed = changespeed; speed > 0; speed -= Time.deltaTime)
        {
            yield return 0;
        }
        cardback.SetActive(true);
        cardback.transform.DORotate(new Vector3(0, 0, 0), changespeed);
        cardfront.SetActive(false);
    }
}
