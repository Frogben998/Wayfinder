using UnityEngine;
using Oculus.Haptics;

public class WallHitScript : MonoBehaviour
{

    public HapticClipPlayer wallHitClipPlayer;
    public HapticClip wallHitClip;
    public AudioSource wallHitAudioSource;
    public AudioClip wallHitAudioClip;

    [SerializeField] private TactileHapticOVRControllerGuidance tactileHapticOVRControllerGuidance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wallHitClipPlayer = new HapticClipPlayer(wallHitClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RightVRController")
        {
 
            wallHitClipPlayer.Play(Controller.Right);

            wallHitAudioSource.Play();
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "RightVRController")
        {
            wallHitClipPlayer.isLooping = true;
            wallHitClipPlayer.Play(Controller.Right);
        }
    }


    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "RightVRController")
        {
            wallHitClipPlayer.Stop();
        }
    }



    protected virtual void OnDestroy()
    {
        wallHitClipPlayer?.Dispose();

    }

    // Upon exiting the application (or when playmode is stopped) we release the haptic clip players and uninitialize (dispose) the SDK.
    protected virtual void OnApplicationQuit()
    {
        Haptics.Instance.Dispose();
    }

}
