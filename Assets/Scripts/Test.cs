using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour {
    public GameObject Obj;
    int counter;
    // Use this for initialization
    void Start()
    {
        Obj.gameObject.SetActive(true);
    }

    public void showhideText()
    {
        counter++;
        if (counter % 2 == 1)
        {
            Obj.gameObject.SetActive(false);
        }
        else
        {
            Obj.gameObject.SetActive(true);
        }
    }
}
