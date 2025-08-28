using UnityEngine;

public class ImpairmentActivateScript : MonoBehaviour
{
    public GameObject impairment;
    public GameObject audioWaypoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RightVRController")
        {
            impairment.SetActive(true);
            audioWaypoint.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RightVRController")
        {
            impairment.SetActive(false);
            audioWaypoint.SetActive(false);
        }
    }

}
