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
    public string ChaoticOutcomeText;
    [TextArea(2, 6)]
    public string NonChaoticOutcomeText;
    [SerializeField] GameObject cross;
    [SerializeField] Button leftbutton;
    [SerializeField] Button rightbutton;
    [SerializeField] bool isthereanALTERNATIVEOUTCOME;
    [SerializeField] bool isALTERNATIVEOUTCOMEcomesafternegative;
    [SerializeField] string alternativeOutcomeText;
    [SerializeField] int ChangeOfKarma;
    [SerializeField] int AlternativeChangeOfKarma;
    [SerializeField] Sprite alternativeOutcomePhoto;
    [SerializeField] int numberOfNessesaryPreviousOutcome;
    [SerializeField] int nessesaryALTERNATIVEOUTCOME;
    [SerializeField] AudioSource Sound;
    void Start()
    {
        cross.SetActive(false);
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
        Sound.Play();
        if (Data.OutcomesInGeneral[Data.iterator_i] == 1)
        {
            if(isthereanALTERNATIVEOUTCOME && isALTERNATIVEOUTCOMEcomesafternegative && Data.OutcomesInGeneral[numberOfNessesaryPreviousOutcome] == nessesaryALTERNATIVEOUTCOME)
            {
                SituationPhoto.sprite = alternativeOutcomePhoto;
                ChaosSlider.value += AlternativeChangeOfKarma;
                Outcome_text.text = alternativeOutcomeText;
            }
            else
            {
                SituationPhoto.sprite = ChaoticOutcome;
                ChaosSlider.value += ChangeOfKarma;
                Outcome_text.text = ChaoticOutcomeText;
            }
            
        }
        else
        {
            if(isthereanALTERNATIVEOUTCOME && !isALTERNATIVEOUTCOMEcomesafternegative && Data.OutcomesInGeneral[numberOfNessesaryPreviousOutcome] == nessesaryALTERNATIVEOUTCOME)
            {
                SituationPhoto.sprite = alternativeOutcomePhoto;
                ChaosSlider.value += AlternativeChangeOfKarma;
                Outcome_text.text = alternativeOutcomeText;
            }
            else
            {
                SituationPhoto.sprite = NonChaoticOutcome;
                ChaosSlider.value -= ChangeOfKarma;
                Outcome_text.text = NonChaoticOutcomeText;
            }
        }
        Data.isChoosed = true;
        Data.iterator_i += 1;
        cross.SetActive(true);
        leftbutton.interactable = false;
        rightbutton.interactable = false;
    }
}
