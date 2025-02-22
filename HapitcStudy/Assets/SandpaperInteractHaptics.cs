using UnityEngine;
using Oculus.Haptics;
public class SandpaperInteractHaptics : MonoBehaviour
{
    //public Collider controllerCollider;
    public HapticClip gravelClip;
    public HapticClipPlayer gravelClipPlayer;
    public HapticClipPlayer hiFreqHiAmpClipPlayer;
    public HapticClipPlayer hiFreqLowAmpClipPlayer;
    public HapticClipPlayer lowFreqHiAmpClipPlayer;
    public HapticClipPlayer lowFreqLowAmpClipPlayer;
    public HapticClip hiFreqHiAmp;
    public HapticClip hiFreqLowAmp;
    public HapticClip lowFreqHiAmp;
    public HapticClip lowFreqLowAmp;
    [SerializeField] public HapticSource sandpaperSource;
    [SerializeField] private TactileHapticOVRControllerGuidance tactileHapticOVRControllerGuidance;
    [SerializeField] private TestingTextScript testingTextScript;
    public int testingIndex = TestingTextScript.CurrentPopUpIndex;
    //public int testingPopUpIndex;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var testingIndexNo = TestingTextScript.CurrentPopUpIndex;
        //gravelClipPlayer = gameObject.GetComponent<HapticSource>();
        sandpaperSource = gameObject.GetComponent<HapticSource>();
        gravelClipPlayer = new HapticClipPlayer(gravelClip);
        hiFreqHiAmpClipPlayer = new HapticClipPlayer(hiFreqHiAmp);
        hiFreqLowAmpClipPlayer = new HapticClipPlayer(hiFreqLowAmp);
        lowFreqHiAmpClipPlayer = new HapticClipPlayer(lowFreqHiAmp);
        lowFreqLowAmpClipPlayer = new HapticClipPlayer(lowFreqLowAmp);
        
    }

    // Update is called once per frame
    void Update()
    {
        testingIndex = TestingTextScript.CurrentPopUpIndex;
    }

    /*public void PlaySandpaperClip(Controller controller)
    {
        switch (controller)
        {
            case Controller.Right:
                sandpaperSource.Play(Controller.Right);
                break;
            case Controller.Left:
                sandpaperSource.Play(Controller.Left);
                break;
            default:
                Debug.LogWarning("Input hand not mapped for: " + controller);
                break;
        }
        Debug.Log("Should feel vibration from clipPlayer1 on " + controller + " controller.");
    }*/

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with something");

        if (collision.gameObject.tag == "LeftVRController")
        {

            switch (testingIndex)
            {
                // 1) default
                case 1:

                    gravelClipPlayer.Play(Controller.Left);
                    Debug.Log("Controller Collided on Gravel Left");
                    break;
                // 2) Hi amp hi freq
                case 2:

                    hiFreqHiAmpClipPlayer.Play(Controller.Left);
                    Debug.Log("Controller Collided on hifreqhiamp Left");
                    break;
                // 3) hi freq low amp
                case 3:

                    hiFreqLowAmpClipPlayer.Play(Controller.Left);
                    Debug.Log("Controller Collided on highfreqlowamp Left");
                    break;
                // 4) low freq high amp
                case 4:

                    lowFreqHiAmpClipPlayer.Play(Controller.Left);
                    Debug.Log("Controller Collided on lowfreqhiamp Left");
                    break;
                // 5) low freq low amp
                case 5:

                    lowFreqLowAmpClipPlayer.Play(Controller.Left);
                    Debug.Log("Controller Collided on lowfreqlowamp Left");
                    break;
                default:

                    break;
            }


            /*gravelClipPlayer.Play(Controller.Left);
            Debug.Log("Controller Collided");*/
        }
        else if (collision.gameObject.tag == "RightVRController")
        {

            switch (testingIndex)
            {
                // 1) Hold Grip Button --> Play haptic sample 2 once
                case 1:

                    gravelClipPlayer.Play(Controller.Right);
                    Debug.Log("Controller Collided on Gravel Right");
                    break;
                // 2) Set loop on first clip (index) using the B/Y-button
                case 2:

                    hiFreqHiAmpClipPlayer.Play(Controller.Right);
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 3) Move thumbsticks to modulate haptic clip
                case 3:

                    hiFreqLowAmpClipPlayer.Play(Controller.Right);
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 4) Test Priority --> Second clip should interrupt first clip
                case 4:

                    lowFreqHiAmpClipPlayer.Play(Controller.Right);
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 5) End of guide.
                case 5:

                    lowFreqLowAmpClipPlayer.Play(Controller.Right);
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                default:

                    break;
            }

        }
    }

    public void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Collided with something");

        if (collision.gameObject.tag == "LeftVRController")
        {

            switch (testingIndex)
            {
                // 1) default
                case 1:

                    gravelClipPlayer.Stop();
                    break;
                // 2) Hi amp hi freq
                case 2:

                    hiFreqHiAmpClipPlayer.Stop();
                    break;
                // 3) hi freq low amp
                case 3:

                    hiFreqLowAmpClipPlayer.Stop();
                    break;
                // 4) low freq high amp
                case 4:

                    lowFreqHiAmpClipPlayer.Stop();
                    break;
                // 5) low freq low amp
                case 5:

                    lowFreqLowAmpClipPlayer.Stop();
                    break;
                default:

                    break;
            }


            /*gravelClipPlayer.Play(Controller.Left);
            Debug.Log("Controller Collided");*/
        }
        else if (collision.gameObject.tag == "RightVRController")
        {

            switch (testingIndex)
            {
                // 1) Hold Grip Button --> Play haptic sample 2 once
                case 1:

                    gravelClipPlayer.Stop();
                    Debug.Log("Controller Collided on Gravel Right");
                    break;
                // 2) Set loop on first clip (index) using the B/Y-button
                case 2:

                    hiFreqHiAmpClipPlayer.Stop();
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 3) Move thumbsticks to modulate haptic clip
                case 3:

                    hiFreqLowAmpClipPlayer.Stop();
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 4) Test Priority --> Second clip should interrupt first clip
                case 4:

                    lowFreqHiAmpClipPlayer.Stop();
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                // 5) End of guide.
                case 5:

                    lowFreqLowAmpClipPlayer.Stop();
                    Debug.Log("Controller Collided on HighFreqHighAmp Right");
                    break;
                default:

                    break;
            }

        }
    }

    protected virtual void OnDestroy()
    {
        gravelClipPlayer?.Dispose();
        hiFreqHiAmpClipPlayer?.Dispose();
        hiFreqLowAmpClipPlayer?.Dispose();
        lowFreqHiAmpClipPlayer?.Dispose();
        lowFreqLowAmpClipPlayer?.Dispose();
    }

    // Upon exiting the application (or when playmode is stopped) we release the haptic clip players and uninitialize (dispose) the SDK.
    protected virtual void OnApplicationQuit()
    {
        Haptics.Instance.Dispose();
    }

}
