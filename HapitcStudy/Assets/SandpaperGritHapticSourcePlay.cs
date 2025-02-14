using Oculus.Haptics;
using UnityEngine;

public class SandpaperGritHapticSourcePlay : MonoBehaviour
{
    public HapticSource source;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnHover()
    {
        source.Play(Controller.Both);
    }

    public void OnHoverExit()
    {
        source.Stop();
    }

}
