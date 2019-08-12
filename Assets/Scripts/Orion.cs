using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Orion : MonoBehaviour
{
    public GameObject orionText;
    int counterorion;
    // Use this for initialization
    void Start()
    {
        orionText.gameObject.SetActive(false);
    }

    public void OrionshowhideText()
    {
        counterorion++;
        if (counterorion % 2 == 1)
        {
            orionText.gameObject.SetActive(true);
        }
        else
        {
            orionText.gameObject.SetActive(false);
        }
    }
}
