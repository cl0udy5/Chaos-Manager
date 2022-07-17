using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider mainslider;
    [SerializeField] Slider nessesaryslaider;
    public TypicalDay mainDay;
    public void SliderStartOfTheDay()
    {
        mainslider.value = 25f;
    }
    
    void Start()
    {
        mainDay = FindObjectOfType<TypicalDay>();
    }

    void Update()
    {
        
    }
    public void SliderEndOfTheDay()
    {
        if(mainslider.value >= 18 && mainslider.value <= 33)
        {
            mainDay.GoodEnding();
        }
        else
        {
            mainDay.BadEnding();
        }
    }
}
