using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GoodEndingMonologue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public AudioSource AlienSpeaking;
    public string[] lines;
    public float textSpeed;
    private int index;
    [SerializeField] GameObject IdlePhoto;
    [SerializeField] GameObject ShowingPhoto;
    [SerializeField] GameObject AngryPhoto;
    [SerializeField] GameObject TellingPhoto;
    [SerializeField] GameObject AskingPhoto;
    [SerializeField] On_Off computer;
    [SerializeField] GameObject Screen;
    [SerializeField] GameObject ParentScene;
    public Button on_off;

    public void Start()
    {
        gameObject.SetActive(true);
        textComponent.text = string.Empty;
        computer = FindObjectOfType<On_Off>();
        StartDialogue();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            AlienSpeaking.Play();
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            switch (index)
            {
                case 1:
                    TellingPhoto.SetActive(false);
                    AskingPhoto.SetActive(true);
                    break;
            }
            StartCoroutine(TypeLine());
        }
        else
        {
            //on_off = GetComponent<Button>();
            on_off.interactable = false;
            ParentScene.SetActive(false);
            gameObject.SetActive(false);
            Screen.SetActive(false);
            // computer.Pressed();
            
        }
    }
}
