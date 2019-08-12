using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class newScript : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Obj1;
    int counter1;
    // Use this for initialization
    void Start()
    {
        Panel1.gameObject.SetActive(false);
    }

    public void showhideText1()
    {
        counter1++;
        if (counter1 % 2 == 1)
        {
            Panel1.gameObject.SetActive(true);
            // Obj.gameObject.SetActive(false);
        }
        else
        {
            Panel1.gameObject.SetActive(false);
            // Obj.gameObject.SetActive(true);
        }
    }
}
