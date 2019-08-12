using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarScript : MonoBehaviour {
    public GameObject Panel;
    public GameObject Obj;
    int counter;
    // Use this for initialization
    void Start()
    {
        Panel.gameObject.SetActive(false);
    }

    public void showhideText()
    {
        counter++;
        if(counter%2==1)
        {
            Panel.gameObject.SetActive(true);
           // Obj.gameObject.SetActive(false);
        }
        else
        {
            Panel.gameObject.SetActive(false);
           // Obj.gameObject.SetActive(true);
        }
    }
}
