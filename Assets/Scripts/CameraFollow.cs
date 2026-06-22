using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float distance = 8f;
    public float height = 5f;

    void LateUpdate()
    {
        transform.position =
            target.position
            - target.forward * distance
            + Vector3.up * height;

        transform.LookAt(target);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
