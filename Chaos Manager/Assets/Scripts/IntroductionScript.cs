using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionScript : MonoBehaviour
{
    public DialogueScript Monologue;
    [SerializeField] GameObject MonologuePanel;
    [SerializeField] Outcome Data;
    public On_Off TheBeggining;
    [SerializeField] TypicalDay Screen;
    public void Start()
    {
        if(!Data.isIntroductionover)
        {
            gameObject.SetActive(true);
            Monologue = FindObjectOfType<DialogueScript>();
            Invoke("StartMonologue", 2f);
        }
        else
        {
            TheBeggining = FindObjectOfType<On_Off>();
            TheBeggining.Pressed();
            Screen = FindObjectOfType<TypicalDay>();
            Screen.ButtonPushed();
        }
        
    }

    void StartMonologue()
    {
        Monologue.Start();
    }

    void Update()
    {
        
    }
}
