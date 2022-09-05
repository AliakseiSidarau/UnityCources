
using UnityEngine;

public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       if(Time.fixedTime < 5)
        {
            transform.localScale = new Vector3(Time.fixedTime, Time.fixedTime, Time.fixedTime);
        }
    }
}
