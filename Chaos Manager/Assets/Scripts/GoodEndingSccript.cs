using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEndingSccript : MonoBehaviour
{
    [SerializeField] GameObject GoodMonologue;
    public void Start()
    {
        gameObject.SetActive(true);
        GoodMonologue.SetActive(true);
    }
}
