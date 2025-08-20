using UnityEngine;

public class ImpairmentActivateScript : MonoBehaviour
{
    public GameObject impairment;

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
        impairment.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        impairment.SetActive(false);
    }

}
