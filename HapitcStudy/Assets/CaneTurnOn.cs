using UnityEngine;

public class CaneTurnOn : MonoBehaviour
{
    public GameObject cane;

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
            cane.SetActive(true);
        }
    }


}
