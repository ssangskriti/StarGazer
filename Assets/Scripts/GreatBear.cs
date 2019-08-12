using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GreatBear : MonoBehaviour
{
    public GameObject GBText;
    int counterbear;
    // Use this for initialization
    void Start()
    {
        GBText.gameObject.SetActive(false);
    }

    public void BearshowhideText()
    {
        counterbear++;
        if (counterbear % 2 == 1)
        {
           GBText.gameObject.SetActive(true);
        }
        else
        {
            GBText.gameObject.SetActive(false);
        }
    }
}
