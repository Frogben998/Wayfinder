using UnityEngine;
using System;
using Oculus.Haptics;

public class TactileHapticOVRControllerGuidance : MonoBehaviour
{

    [SerializeField] private SandpaperInteractHaptics sandpaperInteractHaptics;
    [SerializeField] private MeshCollider leftControllerCollider;
    [SerializeField] private MeshCollider rightControllerCollider;
    [SerializeField] public HapticClipPlayer gravellyClipPlayer;
    [SerializeField] public HapticClip gravelClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sadFace(Controller hand)
    {
        sandpaperInteractHaptics.PlaySandpaperClip(hand);

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
