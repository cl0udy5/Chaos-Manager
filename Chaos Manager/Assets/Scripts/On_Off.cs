using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class On_Off : MonoBehaviour
{
    [SerializeField] Image screen;
    [SerializeField] Sprite turnedOn;
    [SerializeField] Sprite turnedOff;
    [SerializeField] GameObject NumberOfCases;
    bool isTurnedOn;
    
    void Start()
    {
        NumberOfCases.SetActive(false);
    }
    
    public void Pressed()
    {
        if(isTurnedOn)
        {
            screen.sprite = turnedOff;
            isTurnedOn = false;
            NumberOfCases.SetActive(false);
        }
        else
        {
            screen.sprite = turnedOn;
            isTurnedOn = true;
            NumberOfCases.SetActive(true);
        }
    }
}

