using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TypicalDay : MonoBehaviour
{
    [SerializeField] GameObject[] Situations = new GameObject[11]; 
    [SerializeField] GameObject cross;
    [SerializeField] Outcome Data;
    [SerializeField] SliderScript myslider;
    [SerializeField] GameObject BadEnd;
    [SerializeField] GameObject GoodEnd;
    [SerializeField] AudioSource Sound;
    int i;
    bool isOn = false;
    public void ButtonPushed()
    {
        if(isOn)
        {
            Situations[i].SetActive(false);
            isOn = false;
            cross.SetActive(false);
        }
        else
        {
            Situations[i].SetActive(true);
            isOn = true;
            if(Data.isChoosed)
            {
                cross.SetActive(true);
            }
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
        Sound.Play();
        if(i < 10)
        {
            i++;
            Situations[i-1].SetActive(false);
            cross.SetActive(false);
            Invoke("Switch", 0.5f);
            Data.isChoosed = false;
        }
        else
        {
            myslider.SliderEndOfTheDay();
        }
    }
    void Switch()
    {
        Situations[i].SetActive(true);
    }
    public void BadEnding()
    {
        BadEnd.SetActive(true);
        gameObject.SetActive(false);
    }
    public void GoodEnding()
    {
        GoodEnd.SetActive(true);
        gameObject.SetActive(false);
    }

}
