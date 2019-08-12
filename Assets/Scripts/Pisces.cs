using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pisces : MonoBehaviour
{
    public GameObject pisText;
    int counterpis;
    // Use this for initialization
    void Start()
    {
        pisText.gameObject.SetActive(false);
    }

    public void PiscesshowhideText()
    {
        counterpis++;
        if (counterpis % 2 == 1)
        {
            pisText.gameObject.SetActive(true);
        }
        else
        {
            pisText.gameObject.SetActive(false);
        }
    }
}
