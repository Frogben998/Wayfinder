using UnityEngine;
using System;

public class VisualEyeSwap : MonoBehaviour
{
    public GameObject visualEyeColor;
    public GameObject visualEyeHemianopia;
    public GameObject visualEyePeripheralLoss;
    public GameObject totalBlindnessLight;
    public GameObject visualEyeLowContrast;
    public static int currentVisualEyeIndex { get; private set; }




    // key line of code to know:  if (OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.LTouch)
    //B and Y buttons.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        currentVisualEyeIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        VisualEyeSwapper();
    }

    // Unsure if this is the script to have the function in, but at the very least I'll have it built out.
    // ok what this thing is gonna try to do is swap the ActiveVisualEye tag from gameobject to gameobject so that the preview mechanic can work. 
    public void VisualEyeSwapper()
    {
        if (OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.LTouch)){
            currentVisualEyeIndex++;
        }
        Debug.Log("The current Visual Eye Index is: " + currentVisualEyeIndex);
        switch (currentVisualEyeIndex)
        {
            case 0:

                break;
            case 1:
                visualEyeColor.tag = "ActiveVisualEye";
                visualEyeColor.SetActive(true);
                break;
            case 2:
                visualEyeColor.tag = "Untagged";
                visualEyeColor.SetActive(false);
                visualEyeHemianopia.SetActive(true);
                break;
            case 3:
                visualEyeHemianopia.SetActive(false);
                visualEyePeripheralLoss.SetActive(true);
                break;
            case 4:
                visualEyePeripheralLoss.SetActive(false);
                visualEyeLowContrast.SetActive(true);
                break;
            case 5:
                visualEyeLowContrast.SetActive(false);
                currentVisualEyeIndex = 0;
                break;

        }
    }


}
