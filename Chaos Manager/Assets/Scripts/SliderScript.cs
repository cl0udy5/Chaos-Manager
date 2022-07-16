using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider mainslider;
    [SerializeField] Slider nessesaryslaider;
    [SerializeField] Outcome Data;
    public void SliderStartOfTheDay()
    {
        mainslider.value = 25f;
    }
    
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void SliderEndOfTheDay()
    {
        if(mainslider.value >= (nessesaryslaider.value - 10) && mainslider.value <= (nessesaryslaider.value + 10))
        {
            Data.WasTheDayGood[Data.day_iterator_i] = true;
        }
        else
        {
            Data.WasTheDayGood[Data.day_iterator_i] = true;
        }
    }
}
