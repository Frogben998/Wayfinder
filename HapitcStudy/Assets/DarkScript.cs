using UnityEngine;

public class DarkScript : MonoBehaviour
{

    public GameObject lightObject;
    public Light lightToTurnOff;
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
        if (other.gameObject.tag == "RightVRController")
        {
            lightToTurnOff.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "RightVRController") {
        lightToTurnOff.enabled = true;
        }
    }



}
