using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gemini : MonoBehaviour
{
    public GameObject gemText;
    int countergem;
    // Use this for initialization
    void Start()
    {
        gemText.gameObject.SetActive(false);
    }

    public void GeminishowhideText()
    {
        countergem++;
        if (countergem % 2 == 1)
        {
           gemText.gameObject.SetActive(true);
        }
        else
        {
            gemText.gameObject.SetActive(false);
        }
    }
}
