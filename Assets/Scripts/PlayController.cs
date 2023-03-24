using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
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
    private Transform throwDirection;

    [SerializeField]
    private GameObject[] bowlingBallPrefabs;

    public bool wasBallThrown;

    [SerializeField]
    float force;

  


    // Start is called before the first frame update
    void Start()
    {
        wasBallThrown = false;
    }

    // Update is called once per frame
    void Update()
    {


        x = speed * Input.GetAxis("Horizontal");

        // z = speed * Input.GetAxis("Vertical");

        y = 0;


        if (transform.position.x <= leftBound && x > 0 || transform.position.x >= rightBound && x < 0)
        {
            if (wasBallThrown == false)
            {
                transform.Translate(x, y, z);
            }
        }


        if (Input.GetKeyDown("space") && wasBallThrown != true)
        {
            int index = Random.Range(0, bowlingBallPrefabs.Length); 

            GameObject ballClone = Instantiate(bowlingBallPrefabs[index], transform);

            ballClone.GetComponent<Rigidbody>().AddForce(throwDirection.forward * -1000 * force);

            wasBallThrown = true;
             
        }

    }
}

