using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{

    [SerializeField] private Vector3 cameraPos;
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = Vector3.Lerp(new Vector3(player1.transform.position.x, player1.transform.position.y, -10 ), 
            new Vector3(player2.transform.position.x, player2.transform.position.y, -10 ), 0.5f);

        cam.transform.position = cameraPos;
    }
}
