    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
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


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


            x = speed * Input.GetAxis("Horizontal");

            // z = speed * Input.GetAxis("Vertical");

            y = 0;


            if (transform.position.x <= leftBound && x > 0 || transform.position.x >= rightBound && x < 0)
            {

                transform.Translate(x, y, z);
            }


            if (Input.GetKeyDown("space"))
            {
                bowlingBall.AddForce(transform.forward * -1000);  // Same as (0, 0, -1000)

            }

        }
    }
