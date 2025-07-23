using Oculus.Haptics;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class FootstepSoundScript : MonoBehaviour
{
    [SerializeField] private OVRPlayerController OVRPlayerController;
    public AudioSource footstepSource;
    public Vector2 baseVector;
    public InputActionReference inputWalkSystem;
    private Vector3 latePos;
    private Vector3 deltaPos;

    //Going to do this in an inefficient way but here we go

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Taking inputsystem advice from Fist Full of Shrimp's videos on action systems... this does not feel, despite his words, as shrimple as he says it is

    private void Awake()
    {
        inputWalkSystem.action.Enable();
        inputWalkSystem.action.performed += PlayOnMove;
    }

    private void OnDestroy()
    {
        inputWalkSystem.action.Disable();
        inputWalkSystem.action.performed -= PlayOnMove;
    }


    //This... SORT OF works? But its always BEGINNING to play the track, so the track starts playing all uneven and stilted. Still, better than no progress at all.
    private void PlayOnMove(InputAction.CallbackContext context)
    {
       /* footstepSource.Play();
        //footstepSource.volume = 1f;
        Debug.Log("ITS WORKING"); */
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Disconnected:
                inputWalkSystem.action.Disable();
                inputWalkSystem.action.performed -= PlayOnMove;
                break;
            case InputDeviceChange.Reconnected:
                inputWalkSystem.action.Enable();
                inputWalkSystem.action.performed += PlayOnMove;
                break;
        }
    }


    void Start()
    {
        baseVector = new Vector2(1,1);
    }




    // Update is called once per frame
    void Update()
    {
        //HandleStickInput(OVRInput.Controller.LTouch);
        // This statement made the game freeze whenever i moved my head/barely touched the thumbstick
        /* if(OVRPlayerController.MoveThrottle != Vector3.zero)
         {
             footstepSource.Play();
         }
        */
        //Debug.Log(thumbstickInput);
    }

    private void LateUpdate()

        //Function code courtesy of u/CozyRedBear, never even heard of LateUpdate until now
    {
        deltaPos = latePos - transform.position;
        latePos = transform.position;

        if (deltaPos.magnitude == 0)
        {
            //Player isn't moving.
        }

    }


    //Function that SHOULD play sound when left thumbstick is moved, borrowing logic from HapticSdkOVRControllerGuidance.cs
    //For some reason touching this stuff causes what seems to be a memory leak. Must have something to do with the way i'm handling the audio clip itself.
    //Will experiment on how to fix.
    /*  void HandleStickInput(OVRInput.Controller controller)
      {
          Vector2 thumbstickInput = new Vector2(OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x,
              Mathf.Clamp(1.0f + OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).y, 0.0f, 2.0f));

          /  while (thumbstickInput != baseVector)
             {
                 footstepSource.Play();
             }


          Debug.Log(thumbstickInput);

      }
    */


}