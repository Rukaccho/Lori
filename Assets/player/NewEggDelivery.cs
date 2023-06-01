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
    [SerializeField] private AudioSource collectSoundEffect;
  
   
    private void OnTriggerEnter(Collider collider)
    {
        if (!isCarryingEgg.value)
        {
            heldEgg = Instantiate(eggPrefab, playerPosition.position, Quaternion.identity);
            heldEgg.transform.SetParent(playerPosition);
            isCarryingEgg.value = true;
            Debug.Log("Picked up an egg");
            collectSoundEffect.Play();
        }

    }
   
}
