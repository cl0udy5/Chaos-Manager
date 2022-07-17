using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BadMonologue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public AudioSource AlienSpeaking;
    public string[] lines;
    public float textSpeed;
    private int index;
    [SerializeField] GameObject ParentScene;
    [Header("Timer")]
    [SerializeField] GameObject IdlePhoto;
    [SerializeField] GameObject ShowingPhoto;
    [SerializeField] GameObject AngryPhoto;
    [SerializeField] GameObject TellingPhoto;
    [SerializeField] GameObject AskingPhoto;
    [SerializeField] GameObject Screen;
    [SerializeField] Outcome Data;
    [SerializeField] Button on_off;
    [SerializeField] GameObject finalText;

    public void Start()
    {
        gameObject.SetActive(true);
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
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
                    IdlePhoto.SetActive(false);
                    AngryPhoto.SetActive(true);
                    break;
                case 4:
                    AngryPhoto.SetActive(false);
                    ShowingPhoto.SetActive(true);
                    break;
                case 7:
                    ShowingPhoto.SetActive(false);
                    AskingPhoto.SetActive(true);
                    break;
            }
            StartCoroutine(TypeLine());
        }
        else
        {
            on_off.interactable = false;
            ParentScene.SetActive(false);
            gameObject.SetActive(false);
            Screen.SetActive(false);
            finalText.SetActive(true);
        }
    }
}
