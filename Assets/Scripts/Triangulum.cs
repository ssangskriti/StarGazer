using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Triangulum : MonoBehaviour
{
    public GameObject triangulumText;
    int countertri;
    // Use this for initialization
    void Start()
    {
        triangulumText.gameObject.SetActive(false);
    }

    public void TriangulumshowhideText()
    {
        countertri++;
        if (countertri % 2 == 1)
        {
            triangulumText.gameObject.SetActive(true);
        }
        else
        {
            triangulumText.gameObject.SetActive(false);
        }
    }
}
