using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
    
    public GUISkin theSkin;
    public Canvas confirmation;
    public GameObject gob;
    int flag;
    int cnt;
	// Use this for initialization
	void Start () {
        confirmation.enabled = false;
        gob.SetActive(true);
        flag = 0;
        cnt = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void TaskOnClick()
    {
        Debug.Log("Clicked");
    }

    void OnGUI()
    {

        GUI.skin = theSkin;


        if (GUI.Button(new Rect(Screen.width * .8f, Screen.height * 0.5f, Screen.width * .10f, Screen.height * .15f), "Click Me", theSkin.button))

        {
                QuitPress();
        }

    }



    public void QuitPress()

    {
        Debug.Log("Called");
        
        if(flag==0)
        {
            flag = 1;
        }
    }
}
