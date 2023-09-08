using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody2D rigid;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] bool canJump1;
    [SerializeField] private float speed;
    [SerializeField] private  Vector3 movement;
    
    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump1)
        {
            if (Input.GetKeyDown("up"))
            {
                rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                canJump1 = false;
            }
        }

        movement = new Vector3(Input.GetAxis("Horizontal1") * speed*Time.deltaTime, 0, 0);
        transform.position += movement;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        canJump1 = true;
    }
}
