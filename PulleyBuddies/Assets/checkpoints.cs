    using System;
using System.Collections;
using System.Collections.Generic;
    using System.Data;
    using UnityEngine;

public class checkpoints : MonoBehaviour
{

    [SerializeField] private GameObject p1;
    [SerializeField] private GameObject p2;
    [SerializeField] private bool p1Ready;
    [SerializeField] private bool p2Ready;
    [SerializeField] private Transform p1Spawn;
    [SerializeField] private Transform p2Spawn;
    [SerializeField] private bool canSpawn = false;
    [SerializeField] private GameObject rock;
    [SerializeField] private Transform rockSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((p1Ready) & (p2Ready))
        {
            canSpawn = true;

        }
        if ((Input.GetKeyDown("1")) & (canSpawn))
        {
            p1.transform.position = p1Spawn.transform.position;
            p2.transform.position = p2Spawn.transform.position;
        }

        if ((Input.GetKeyDown("r") & (canSpawn)))
        {
            rock.transform.position = rockSpawn.transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("p1"))
        {
            p1Ready = true;
        }
        if (other.CompareTag("p2"))
        {
            p2Ready = true;
        }
    }
    
   
}
