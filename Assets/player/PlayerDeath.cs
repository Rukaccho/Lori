using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public static bool isCarryingEgg = false;
    private EggzController heldEgg;
    public Transform deliveryLocation;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            if (isCarryingEgg)
            {
                heldEgg.transform.parent = null;
                Destroy(heldEgg.gameObject);
                isCarryingEgg = false;
                Debug.Log("You Died and lost your Egg.");
            }
            else
            {
                transform.position = deliveryLocation.position;

                Debug.Log("You Died.");
            }
        }
    }
}
