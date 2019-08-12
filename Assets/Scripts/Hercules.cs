using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hercules : MonoBehaviour
{
    public GameObject herText;
    int counterher;
    // Use this for initialization
    void Start()
    {
        herText.gameObject.SetActive(false);
    }

    public void HerculesshowhideText()
    {
        counterher++;
        if (counterher % 2 == 1)
        {
            herText.gameObject.SetActive(true);
        }
        else
        {
            herText.gameObject.SetActive(false);
        }
    }
}
