using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Leo : MonoBehaviour
{
    public GameObject leoText;
    int counterleo;
    // Use this for initialization
    void Start()
    {
        leoText.gameObject.SetActive(false);
    }

    public void LeoshowhideText()
    {
        counterleo++;
        if (counterleo % 2 == 1)
        {
            leoText.gameObject.SetActive(true);
        }
        else
        {
            leoText.gameObject.SetActive(false);
        }
    }
}
