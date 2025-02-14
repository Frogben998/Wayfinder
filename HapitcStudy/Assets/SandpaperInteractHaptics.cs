using UnityEngine;
using Oculus.Haptics;
public class SandpaperInteractHaptics : MonoBehaviour
{
    public Collider controllerCollider;
    //public HapticClip gravelClip;
    public HapticClipPlayer gravelClipPlayer;
    public HapticSource sandpaperSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gravelClipPlayer = gameObject.GetComponent<HapticSource>();
        sandpaperSource = gameObject.GetComponent<HapticSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(Controller controller)
    {
        
    }

    public void OnCollisionStay(Collision collision)
    {
        //Play();
    }
}
