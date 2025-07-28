using UnityEngine;

public class StayInPlace : MonoBehaviour
{
    private Vector3 initialPlace;
    private Quaternion initialRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPlace = gameObject.transform.position;
        initialRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = initialPlace;
        gameObject.transform.rotation = initialRotation;
    }
}
