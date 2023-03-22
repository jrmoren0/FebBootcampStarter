using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float x;
    private float z;
    private float y;


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

        y = 0;


        //Send data to animator for visual feedback on character movement 
        foxAnim.SetFloat("vertical", Input.GetAxis("Vertical"));

        foxAnim.SetFloat("horizontal", Input.GetAxis("Horizontal"));


        //Moves character
        transform.Translate(x, y, z);
        

        if (Input.GetKeyDown("space"))
        {
            foxAnim.SetBool("space", true);
        }

        if (Input.GetKeyUp("space"))
        {
            foxAnim.SetBool("space", false);
        }

    }
}
