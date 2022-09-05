using UnityEngine;

public class Teleport : MonoBehaviour
{
    private float nextTime = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time > nextTime)
        {
            nextTime++;
            transform.position = new Vector3(Random.Range(-5f, 9f), 2f, Random.Range(-12f, 12f));
        }
    }
}
