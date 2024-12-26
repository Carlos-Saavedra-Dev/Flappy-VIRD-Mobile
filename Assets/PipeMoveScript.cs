using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public static float moveSpeed = 5;
    public float deadZone = -16;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        { 
            Destroy(gameObject);
        }
    }
}
