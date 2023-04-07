using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    [SerializeField]
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        wasBallThrown = false;
    }

    // Update is called once per frame
    void Update()
    {

        // transform.position.x 
        x = speed * slider.value * -1;
        y = 0;

         if (transform.position.x <= leftBound && x > 0 || transform.position.x >= rightBound && x < 0)
        {
            if (wasBallThrown == false)
            {
                transform.Translate(x, y, z);
            }
        }





          /*  x = speed * Input.GetAxis("Horizontal");
            // z = speed * Input.GetAxis("Vertical");
            y = 0;
            // if the player is within the given bounds update x
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
                ballClone.GetComponent<Rigidbody>().AddForce(throwDirection.forward * -1 * force,ForceMode.Impulse);
                wasBallThrown = true;     
            }

         */


        //#if Unity_IOS || UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > Screen.width / 2)
            {

                if (wasBallThrown == false)
                {
                    transform.Translate(transform.right * Time.deltaTime);
                }

            }
            else if (touch.position.x < Screen.width / 2)

            {
                if (wasBallThrown == false)
                {
                    transform.Translate(transform.right * -1 * Time.deltaTime);
                }
            }


        }
       // #endif
    }


    public void ThrowBall() {

        int index = Random.Range(0, bowlingBallPrefabs.Length);
        GameObject ballClone = Instantiate(bowlingBallPrefabs[index], transform);
        ballClone.GetComponent<Rigidbody>().AddForce(throwDirection.forward * -1 * force, ForceMode.Impulse);
        wasBallThrown = true;
    }


    public void SliderMove()
    {
       // transform.position.x += slider.value;

    }
}

