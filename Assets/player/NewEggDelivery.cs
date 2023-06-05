using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class NewEggDelivery : MonoBehaviour
{
    public Transform playerPosition;
    public BoolValue isCarryingEgg;
    public EggzController eggPrefab;
    private EggzController heldEgg;
    public EndEggDelivery endEggDelivery;
    [SerializeField] private AudioSource collectSoundEffect;
    public int deliveryCount = 0;
    public List<GameObject> gniazdo;

    private void OnTriggerEnter(Collider collider)
    {
        if (!isCarryingEgg.value)
        {
            heldEgg = Instantiate(eggPrefab, playerPosition.position, Quaternion.identity);
            heldEgg.transform.SetParent(playerPosition);
            isCarryingEgg.value = true;
            Debug.Log("Picked up an egg");
            collectSoundEffect.Play();
            endEggDelivery.SetLastPickupSpot(this);
        }

    }
    public void IncrementDeliveryCount()
    {
        deliveryCount++;
        while (deliveryCount >= 3)
        {
            foreach (GameObject gameObject in gniazdo)
            {
                gameObject.SetActive(false);
            }

            gameObject.SetActive(false);
            break;
        }
    }
}
