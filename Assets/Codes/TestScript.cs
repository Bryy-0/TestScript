using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNameSpace;

public class TestScript : MonoBehaviour
{
    private SimpleScripts simpleScripts;
    public Texture2D btnImage;
    private string newuserName;
    private void Start()
    {
        simpleScripts = GetComponent<SimpleScripts>();

    }

    private void OnGUI()
    {
        newuserName = GUI.TextField(new Rect(10, 10, 100, 30), newuserName);
        if (GUI.Button(new Rect(10, 10, 100, 50), "Press ME"))
        {
            simpleScripts.userName = newuserName;
            /*string newUserName = simpleScripts.userName;
            Debug.Log(newUserName);*/
        }
    }
}
