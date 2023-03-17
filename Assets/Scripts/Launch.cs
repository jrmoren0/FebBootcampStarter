using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{


    [SerializeField]
    private Rigidbody dog;


    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            dog.AddForce(transform.up * speed, ForceMode.Impulse);

        }
    }
}
