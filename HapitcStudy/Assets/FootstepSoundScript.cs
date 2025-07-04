using UnityEngine;
using System;

public class FootstepSoundScript : MonoBehaviour
{
    [SerializeField] private OVRPlayerController OVRPlayerController;
    public AudioSource footstepSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(OVRPlayerController.MoveThrottle != Vector3.zero)
        {
            footstepSource.Play();
        }


    }
}
