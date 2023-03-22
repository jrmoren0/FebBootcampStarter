using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField]
    private PlayController playController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            Destroy(other.gameObject);
            playController.wasBallThrown = false;
        }

    }
}
