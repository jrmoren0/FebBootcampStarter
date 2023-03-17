using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float x;
    private float z;
    private float y;


    [SerializeField]
    private float leftBound;


    [SerializeField]
    private float rightBound;


    [SerializeField]
    private Rigidbody bowlingBall;

    [SerializeField]
    private Animator foxAnim;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        x = speed * Input.GetAxis("Horizontal");

        z = speed * Input.GetAxis("Vertical");

        foxAnim.SetFloat("vertical", z);
        foxAnim.SetFloat("horizontal", x);
        

        y = 0;


       

       transform.Translate(x, y, z);
        


        if (Input.GetKeyDown("space"))
        {
            foxAnim.SetBool("space", true);
            bowlingBall.AddForce(transform.up * 100);  

        }
        if (Input.GetKeyUp("space"))
        {
            foxAnim.SetBool("space", false);
        }

    }
}

