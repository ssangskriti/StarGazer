using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Aquarius : MonoBehaviour
{
    public GameObject aquaText;
    int counteraqua;
    // Use this for initialization
    void Start()
    {
        aquaText.gameObject.SetActive(false);
    }

    public void AquariusshowhideText()
    {
        counteraqua++;
        if (counteraqua % 2 == 1)
        {
            aquaText.gameObject.SetActive(true);
        }
        else
        {
            aquaText.gameObject.SetActive(false);
        }
    }
}
