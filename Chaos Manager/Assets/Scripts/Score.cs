using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreint = 11;
    [SerializeField] TextMeshProUGUI scorenumber;
    void Start()
    {
        scorenumber.text = "Cases left:\n" + scoreint;
    }
    public void ScoreChange()
    {
        if(scoreint >= 1)
        {
            scoreint --;
            scorenumber.text = "Cases left:\n" + scoreint;
        }
    }   
}
