using UnityEngine;

public class DarkScript : MonoBehaviour
{

    public GameObject lightObject;
    public Light lightToTurnOff;
    public VisualEyeSwap visualEyeSwap;
    public GameObject visualEyeColorToCollide;
    public GameObject visualEyeHemianopiaToCollide;
    public GameObject visualEyePeripheralLossToCollide;
    public GameObject totalBlindnessLightToCollide;
    public GameObject visualEyeLowContrastToCollide;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightToTurnOff = lightObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == "RightVRController")
        {
            //lightToTurnOff.enabled = false;
        }*/

        switch (VisualEyeSwap.currentVisualEyeIndex)
        {
            case 0:

                break;
            case 1:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeColorToCollide.SetActive(true);
                }

                break;
            case 2:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeHemianopiaToCollide.SetActive(true);
                }

                break;
            case 3:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyePeripheralLossToCollide.SetActive(true);
                }

                break;
            case 4:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeLowContrastToCollide.SetActive(true);
                }

                break;
            case 5:

                break;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        switch (VisualEyeSwap.currentVisualEyeIndex)
        {
            case 0:

                break;
            case 1:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeColorToCollide.SetActive(false);
                }

                break;
            case 2:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeHemianopiaToCollide.SetActive(false);
                }

                break;
            case 3:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyePeripheralLossToCollide.SetActive(false);
                }

                break;
            case 4:
                if (other.gameObject.tag == "RightVRController")
                {
                    visualEyeLowContrastToCollide.SetActive(false);
                }

                break;
            case 5:

                break;

        }

    }



}
