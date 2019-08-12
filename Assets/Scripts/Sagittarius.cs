using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sagittarius : MonoBehaviour
{
    public GameObject sagiText;
    int countersagi;
    // Use this for initialization
    void Start()
    {
        sagiText.gameObject.SetActive(false);
    }

    public void sagittariusshowhideText()
    {
        countersagi++;
        if (countersagi % 2 == 1)
        {
            sagiText.gameObject.SetActive(true);
        }
        else
        {
            sagiText.gameObject.SetActive(false);
        }
    }
}
