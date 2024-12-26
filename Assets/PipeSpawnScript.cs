using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heighOffSet = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint =  transform.position.y - heighOffSet;
        float highestPoint = transform.position.y + heighOffSet;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);

    }

}
