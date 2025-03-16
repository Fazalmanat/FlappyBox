using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float timer=0;
    public float heightoffset = 10;
    public parent paren;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {   if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }
    void spawn()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highpoint = transform.position.x + heightoffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,highpoint),0), transform.rotation);
    }
}
