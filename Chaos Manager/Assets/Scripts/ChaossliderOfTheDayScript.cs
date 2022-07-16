using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaossliderOfTheDayScript : MonoBehaviour
{
    [SerializeField] Slider ThisSlider;
    [SerializeField] Outcome Data;
    public void NewDay()
    {
        ThisSlider.value = Data.SliderOfTheDay[Data.day_iterator_i];
    }
}
