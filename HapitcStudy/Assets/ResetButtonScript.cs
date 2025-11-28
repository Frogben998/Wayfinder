using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ResetButtonScript : MonoBehaviour
{
    public string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetScene();
    }

    public void ResetScene()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
