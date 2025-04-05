using UnityEngine;

public class SpawningStart : MonoBehaviour
{
    public GameObject spawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform playerTransform = GameObject.FindWithTag("Player").transform;
        playerTransform.position = spawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
