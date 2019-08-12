using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Virgo : MonoBehaviour
{
    public GameObject virgoText;
    int countervirgo;
    // Use this for initialization
    void Start()
    {
        virgoText.gameObject.SetActive(false);
    }

    public void VirgoshowhideText()
    {
        countervirgo++;
        if (countervirgo % 2 == 1)
        {
            virgoText.gameObject.SetActive(true);
        }
        else
        {
            virgoText.gameObject.SetActive(false);
        }
    }
}
