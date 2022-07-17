using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BadEndingScript : MonoBehaviour
{
    [SerializeField] GameObject BadMonologue;

    public void Start()
    {
        gameObject.SetActive(true);
        BadMonologue.SetActive(true);
    }
}
