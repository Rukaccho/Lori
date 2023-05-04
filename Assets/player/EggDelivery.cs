using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}
