using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    public float heightOffset = 10;
    public int difficulty = 1;
    private int difficultySpikeInterval = 0;
    private float timer = 0;
    public float timePassed = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        if (spawnRate > 1)
        {
            if (timePassed > (8 / difficulty) * difficultySpikeInterval)
            {
                difficultySpikeInterval += 1;
                spawnRate -= 0.1f;
            }
        }
    }
    void spawnPipe()
    {
        float lowestOffset = transform.position.y - heightOffset;
        float highestOffset = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestOffset, highestOffset), 0), transform.rotation);
    }
}
