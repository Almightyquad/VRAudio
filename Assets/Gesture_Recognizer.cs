using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gesture_Recognizer : MonoBehaviour {

    bool rightControllerActive = false;
    bool leftControllerActive = false;
    GameObject canvas;
    GameObject left;
    GameObject right;
    GameObject both;
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("ControllerCanvas");
        right = canvas.transform.FindChild("Right").gameObject;
        left = canvas.transform.FindChild("Left").gameObject;
        both = canvas.transform.FindChild("Both").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        List<GameObject> touchingObjects = this.GetComponent<VRTK.VRTK_InteractableObject>().GetTouchingObjects();
    
        foreach(GameObject g in touchingObjects)
        {
            if(g.name == "RightController")
            {
                rightControllerActive = true;
            }
            else if(g.name == "LeftController")
            {
                leftControllerActive = true;
            }
        }
        if (touchingObjects.Count == 0)
        {
            rightControllerActive = false;
            leftControllerActive = false;
        }
        if (rightControllerActive == true)
        {
            right.transform.FindChild("Text").GetComponent<Text>().text = "Right: True";
        }
        else
        {
            right.transform.FindChild("Text").GetComponent<Text>().text = "Right: False";
        }
        if (leftControllerActive == true)
        {
            left.transform.FindChild("Text").GetComponent<Text>().text = "Left: True";
        }
        else
        {
            left.transform.FindChild("Text").GetComponent<Text>().text = "Left: False";
        }
        if (rightControllerActive == true && leftControllerActive == true)
        {
            both.transform.FindChild("Text").GetComponent<Text>().text = "Both: True";
        }
        else
        {
            both.transform.FindChild("Text").GetComponent<Text>().text = "Both: false";
        }
	}
}
