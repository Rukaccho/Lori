using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EggDelivery : MonoBehaviour
{
    public Transform[] pickupLocations;
    public Transform deliveryLocation;
    public float pickupDistance = 2f;
    public float deliveryDistance = 2f;

    public GameObject eggPrefab;
    private GameObject heldEgg;
    private bool deliveredEgg = false;
    private int score = 0;
    private bool isCarryingEgg = false;
    private Vector3 lastSafeDropPosition;

    public Text scoreText;

    public int GetScore()
    {
        return score;
    }
    private void Start()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {

    }
    void Update()
    {
        foreach (Transform pickupLocation in pickupLocations)
        {
            if (!isCarryingEgg && Vector3.Distance(transform.position, pickupLocation.position) < pickupDistance)
            {
                heldEgg = Instantiate(eggPrefab, pickupLocation.position, Quaternion.identity);
                heldEgg.transform.SetParent(transform);
                isCarryingEgg = true;
                Debug.Log("Picked up egg from " + pickupLocation.name);
            }
        }

        if (isCarryingEgg && Vector3.Distance(transform.position, deliveryLocation.position) < deliveryDistance)
        {
            Destroy(heldEgg);
            deliveredEgg = true;
            score++;

            isCarryingEgg = false;
            Debug.Log("Delivered egg!");
            UpdateScoreText();
        }

        if (deliveredEgg && Vector3.Distance(transform.position, deliveryLocation.position) > deliveryDistance)
        {
            deliveredEgg = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // If the player collides with an obstacle while carrying an egg
            if (isCarryingEgg)
            {
               
                heldEgg.transform.parent = null;
                Destroy(heldEgg);
                isCarryingEgg = false;

                // Respawn the player at the base location
                transform.position = deliveryLocation.position;

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
