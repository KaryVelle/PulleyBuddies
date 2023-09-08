using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBig : MonoBehaviour
{
    [SerializeField] private bool isP1Big = true;

    [SerializeField] private GameObject player1;

    [SerializeField] private GameObject player2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Change weight");

            if (isP1Big)
            {
                //P1 BIG
                Debug.Log(isP1Big);
                player1.GetComponent<Rigidbody2D>().gravityScale = 5;
                player1.transform.localScale = new Vector3(1f, 1f, 1);

                //P2 SMALL
                player2.GetComponent<Rigidbody2D>().gravityScale = 1;
                player2.transform.localScale = new Vector3(0.5f, 0.5f, 1);


                isP1Big = false;

            }
            else
            {
                //P2 BIG 
                player2.GetComponent<Rigidbody2D>().gravityScale = 5;
                player2.transform.localScale = new Vector3(1f, 1f, 1);

                //P1 SMALL
                player1.GetComponent<Rigidbody2D>().gravityScale = 1;
                player1.transform.localScale = new Vector3(0.5f, 0.5f, 1);


                isP1Big = true;

            }
        }


    }

}
