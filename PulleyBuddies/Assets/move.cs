using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody2D rigid;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] bool canJump1;
    [SerializeField] private float speed;
    [SerializeField] private new Vector3 movement;
    
    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {

        
            if (canJump1)
            {
                if (Input.GetKeyDown("w"))
                {
                    rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    canJump1 = false;
                }
            }
            movement = new Vector3(Input.GetAxis("Horizontal2") * speed *Time.deltaTime, 0, 0);
            transform.position += movement;
            


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        canJump1 = true;
    }
}
