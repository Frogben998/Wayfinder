using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
//using UnityEngine.XRModule;

public class CollisionHaptic : MonoBehaviour
{
    [System.Obsolete]
    XRBaseController thisController;
    public Collider controllerCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    void Start()
    {
        thisController = GetComponent<XRBaseController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void SendHapticFeedback(BaseInteractionEventArgs args)
    {
        args.interactorObject.transform.GetComponent<XRBaseController>().SendHapticImpulse(1f,2f);
        //thisController.SendHapticImpulse(1f, 1.5f);
    }

    [System.Obsolete]
    public void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Sandpaper")
        {
            //SendHapticFeedback();
            thisController.SendHapticImpulse(1f, 1f);
        }
    }


}
