using Oculus.Haptics;
using UnityEngine;

public class SandpaperHapticPlayOnHover : MonoBehaviour
{

    public HapticClip hapticClip;
    private HapticClipPlayer clipPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clipPlayer = new HapticClipPlayer(hapticClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerHaptics(OVRInput.Controller controller)
    {
        
    }



}
