
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.RotateAround(transform.position, Vector3.up, 3);
    }
    
}
