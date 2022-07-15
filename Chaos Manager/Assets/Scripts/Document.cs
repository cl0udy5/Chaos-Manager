using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Document : MonoBehaviour
{
    [SerializeField] GameObject document;

    public void Delete()
    {
        document.SetActive(false);
    }
    
}
