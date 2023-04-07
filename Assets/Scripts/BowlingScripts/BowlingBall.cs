using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
 
   private AudioSource strike;

    private void Start()
    {
     GameObject strikeObject = GameObject.FindGameObjectWithTag("Strike");

      strike = strikeObject.GetComponent<AudioSource>();

        Destroy(gameObject,4);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            strike.Play();
        }
    }


}
