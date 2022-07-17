using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Outcomes", fileName = "PossibleOutcome")]
public class Outcome : ScriptableObject
{
    public int iterator_i = 0;
    public string[] ChaoticOutcomes = new string[11];
    public int[] OutcomesInGeneral = new int[11];
    public int day_iterator_i = 0;
    public bool isChoosed;
    public bool isIntroductionover;

    public void UrChaoticChoice()
    {
        OutcomesInGeneral[iterator_i] = 1;
    }
    public void UrNonChaoticChoice()
    {
        OutcomesInGeneral[iterator_i] = -1;
    }
    void Start()
    {
        day_iterator_i = 0;
        iterator_i = 0;
        for(int i = 0; i < 21; i++)
        {
            OutcomesInGeneral[i] = 0;
        }
    }
}