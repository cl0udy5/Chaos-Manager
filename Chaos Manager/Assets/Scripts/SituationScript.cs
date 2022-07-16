using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SituationScript : MonoBehaviour
{
    [SerializeField] Slider ChaosSlider;
    [SerializeField] Outcome Data;
    [SerializeField] Image SituationPhoto;
    [SerializeField] Sprite ChaoticOutcome;
    [SerializeField] Sprite NonChaoticOutcome;
    [SerializeField] TextMeshProUGUI Outcome_text;
    [TextArea(2, 6)]
    [SerializeField] string ChaoticOutcomeText;
    [TextArea(2, 6)]
    [SerializeField] string NonChaoticOutcomeText;
    [SerializeField] GameObject cross;
    [SerializeField] Button leftbutton;
    [SerializeField] Button rightbutton;

    void Start()
    {
        cross.SetActive(false);
    }

    void Update()
    {
        
    }
    public void LeftChoise()
    {
        if (Data.ChaoticOutcomes[Data.iterator_i] == "left")
        {
            Data.UrChaoticChoice();
        }
        else
        {
            Data.UrNonChaoticChoice();
        }
    }

    public void RightChoise()
    {
        if (Data.ChaoticOutcomes[Data.iterator_i] == "right")
        {
            Data.UrChaoticChoice();
        }
        else
        {
            Data.UrNonChaoticChoice();           
        }
    }

    public void AnyChoice()
    {
        if (Data.OutcomesInGeneral[Data.iterator_i] == 1)
        {
            SituationPhoto.sprite = ChaoticOutcome;
            ChaosSlider.value += 5;
            Outcome_text.text = ChaoticOutcomeText;
        }
        else
        {
            SituationPhoto.sprite = NonChaoticOutcome;
            ChaosSlider.value -= 5;
            Outcome_text.text = NonChaoticOutcomeText;
        }
        Data.iterator_i += 1;
        cross.SetActive(true);
        leftbutton.interactable = false;
        rightbutton.interactable = false;
    }
}
