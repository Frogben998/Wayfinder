using UnityEngine;
using System;
using Oculus.Haptics;

public class TactileHapticOVRControllerGuidance : MonoBehaviour
{

    [SerializeField] private SandpaperInteractHaptics sandpaperInteractHaptics;
    [SerializeField] private MeshCollider leftControllerCollider;
    [SerializeField] private WallHitScript wallHitScript;
    [SerializeField] private MeshCollider rightControllerCollider;
    [SerializeField] public HapticClipPlayer gravellyClipPlayer;
    [SerializeField] public HapticClip gravelClip;
    [SerializeField] public TestingTextScript testingTextScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        HandleHapticsSdkGuidanceStep();
    }


    public void HandleHapticsSdkGuidanceStep()
    {
        switch (TestingTextScript.CurrentPopUpIndex)
        {
            case 0:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 1:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 2:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 3:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 4:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 5:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            case 6:
                if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) ||
                OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
                {
                    testingTextScript.NextStep();
                }
                break;
            default:
                break;
        }
    }


    /*  void OnCollisionEnter(Collision collision)
      {
          if (collision.collider.tag == "Sandpaper")
          {
              sandpaperInteractHaptics.PlaySandpaperClip(sandpaperInteractHaptics.controller);
          }
      }
    */


}
