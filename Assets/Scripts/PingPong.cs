using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 direction;
    public string checker;
    private Vector3 point1 = new Vector3(9f, 2f, -12f);
    private Vector3 point2 = new Vector3(-5f, 2f, -12f);

    void Start()
    {
    
    }

    void FixedUpdate()
    {
        Check();
        switch (checker)
        {
            case "up":
                transform.position = Vector3.MoveTowards(transform.position, point1, 0.1f);
                break;
            case "down":
                transform.position = Vector3.MoveTowards(transform.position, point2, 0.1f);
                break;
            default:
                break;
        }
    }

    void Check()
    {
        if (transform.position == point1)
        {
            checker = "down";
        }
        else if(transform.position == point2)
        {
            checker = "up";
        }
    }
}
