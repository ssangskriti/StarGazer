using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scorpius : MonoBehaviour
{
    public GameObject scorText;
    int counterscor;
    // Use this for initialization
    void Start()
    {
        scorText.gameObject.SetActive(false);
    }

    public void ScorpiusshowhideText()
    {
        counterscor++;
        if (counterscor % 2 == 1)
        {
            scorText.gameObject.SetActive(true);
        }
        else
        {
            scorText.gameObject.SetActive(false);
        }
    }
}
