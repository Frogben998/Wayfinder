using UnityEngine;
using System.Collections;
using TMPro;
public class TimerScript : MonoBehaviour
{
    public float timerVar;
    public TextMeshPro timerString;
    public bool isCounting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timerString.text = timerVar.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCounting == true)
        {
            timerVar += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RightVRController")
        {
            isCounting = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RightVRController")
        {
            isCounting = false;
            timerString.text = timerVar.ToString();
        }
    }

}
