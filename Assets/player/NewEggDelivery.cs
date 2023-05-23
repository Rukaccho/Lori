using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewEggDelivery : MonoBehaviour
{
    public Transform deliveryLocation;
    public Transform playerPosition;
    public static bool isCarryingEgg = false;
    public EggzController eggPrefab;
    private EggzController heldEgg;
    private bool deliveredEgg = false;
    private int score = 0;
    public ParticleController particleController;
    public float deliveryDistance = 2f;
    public GameEvent playerDeliveredEgg;

    public int GetScore()
    {
        return score;
    }
    void UpdateScoreText()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (!isCarryingEgg)
        {
            heldEgg = Instantiate(eggPrefab, playerPosition.position, Quaternion.identity);
            heldEgg.transform.SetParent(playerPosition);
            isCarryingEgg = true;
            Debug.Log("Picked up an egg");
        }

    }
    void Update()
    {
        if (isCarryingEgg && Vector3.Distance(playerPosition.position, deliveryLocation.position) < deliveryDistance)
        {
            playerDeliveredEgg.Fire();
            deliveredEgg = true;
            score += heldEgg.egg.worth;
            Destroy(heldEgg.gameObject);
            isCarryingEgg = false;
            Debug.Log("Delivered egg!");
            UpdateScoreText();
            particleController.PlayParticles();
        }

        if (deliveredEgg && Vector3.Distance(playerPosition.position, deliveryLocation.position) > deliveryDistance)
        {
            deliveredEgg = false;
        }


    }
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
                //transform.position = deliveryLocation.position;

                Debug.Log("You Died.");
            }
        }
    }
}
