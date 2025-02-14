using Oculus.Haptics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusHapticTriggerOnCollision : MonoBehaviour
{
    public float duration;
    public float amplitude;
    public float frequency;

    //public GrabInteractable grabInteractable;
    public OVRGrabbable grabbable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //grabInteractable.WhenSelectingInteractorAdded.Action +=  
        //grabbable.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerHaptics(OVRInput.Controller controller)
    {
        StartCoroutine(TriggerHapticsRoutine(controller));
    }

    public IEnumerator TriggerHapticsRoutine(OVRInput.Controller controller)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, controller);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0, 0, controller);
    }

}
