using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Outcomes", fileName = "PossibleOutcome")]
public class Outcome : ScriptableObject
{
    public int iterator_i = 0;
    public string[] ChaoticOutcomes = new string[21];
    public int[] OutcomesInGeneral = new int[21];
    public int[] SliderOfTheDay = new int[3];
    public int day_iterator_i = 0;
    public bool[] WasTheDayGood = new bool[3];

    public void UrChaoticChoice()
    {
        OutcomesInGeneral[iterator_i] = 1;
    }
    public void UrNonChaoticChoice()
    {
        OutcomesInGeneral[iterator_i] = -1;
    }
}
