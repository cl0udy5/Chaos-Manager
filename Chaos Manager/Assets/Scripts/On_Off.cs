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
    [SerializeField] GameObject glare;
    [SerializeField] Outcome Data;
    public bool isTurnedOn;
    
    void Start()
    {
        screen.sprite = turnedOff;
        NumberOfCases.SetActive(false);
        glare.SetActive(false);
        Data.iterator_i = 0;
    }

    public void Pressed()
    {
        if(isTurnedOn)
        {
            screen.sprite = turnedOff;
            isTurnedOn = false;
            NumberOfCases.SetActive(false);
            glare.SetActive(false);
        }
        else
        {
            screen.sprite = turnedOn;
            isTurnedOn = true;
            NumberOfCases.SetActive(true);
            glare.SetActive(true);
        }
    }
}

