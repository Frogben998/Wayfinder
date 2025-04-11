using UnityEngine;
using System.Collections;
using TMPro;
public class TimerScript : MonoBehaviour
{
    public float timerVar;
    public TextMeshPro timerString;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerString.text = timerVar.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timerString.text = timerVar.ToString();
        timerVar += Time.deltaTime;
    }
}
