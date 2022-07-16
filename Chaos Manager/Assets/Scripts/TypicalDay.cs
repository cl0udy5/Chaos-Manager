using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TypicalDay : MonoBehaviour
{
    [SerializeField] GameObject[] Situations = new GameObject[7]; 
    int i;
    bool isOn = false;
    public void ButtonPushed()
    {
        if(isOn)
        {
            Situations[i].SetActive(false);
            isOn = false;
        }
        else
        {
            Situations[i].SetActive(true);
            isOn = true;
        }
        

    }

    void Start() 
    {
        i = 0;
    }

    void Update()
    {
        
    }
    public void ChangeSituations()
    {
        i++;
        Situations[i].SetActive(true);
        Situations[i-1].SetActive(false);
        
    }
    public void NewDay()
    {

    }

}
