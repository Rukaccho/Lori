using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public BoolValue isCarryingEgg;
    private EggzController heldEgg;
    public Transform deliveryLocation;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            if (isCarryingEgg.value)
            {
                heldEgg = GetComponentInChildren<EggzController>();

                heldEgg.transform.parent = null;
                Destroy(heldEgg.gameObject);
                isCarryingEgg.value = false;
                Debug.Log("You Died and lost your Egg.");
                transform.position = deliveryLocation.position;
            }
            else
            {
                transform.position = deliveryLocation.position;

                Debug.Log("You Died.");
            }
        }
    }
}
