using UnityEngine;
using Oculus.Haptics;
public class SandpaperInteractHaptics : MonoBehaviour
{
    //public Collider controllerCollider;
    public HapticClip gravelClip;
    public HapticClipPlayer gravelClipPlayer;
    [SerializeField] public HapticSource sandpaperSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gravelClipPlayer = gameObject.GetComponent<HapticSource>();
        sandpaperSource = gameObject.GetComponent<HapticSource>();
        gravelClipPlayer = new HapticClipPlayer(gravelClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySandpaperClip(Controller controller)
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
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with something");
        
        if(collision.gameObject.tag == "LeftVRController")
        {
            gravelClipPlayer.Play(Controller.Left);
            Debug.Log("Controller Collided");
        }
        else if(collision.gameObject.tag == "RightVRController")
        {
            gravelClipPlayer.Play(Controller.Right);
            Debug.Log("Controller Collided");
        }
        
    }

    public void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Collided with something");

        if (collision.gameObject.tag == "LeftVRController")
        {
            gravelClipPlayer.Stop();
            Debug.Log("Controller Collided");
        }
        else if (collision.gameObject.tag == "RightVRController")
        {
            gravelClipPlayer.Stop();
            Debug.Log("Controller Collided");
        }
    }


}
