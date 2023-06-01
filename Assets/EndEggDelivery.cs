using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EndEggDelivery : MonoBehaviour
{
    public BoolValue isCarryingEgg;
    public GameEvent playerDeliveredEgg;
    public ScoreValue totalScore;
    private EggzController heldEgg;
    public ParticleController particleController;
    [SerializeField] private AudioSource returnSoundEffect;
    private void OnTriggerEnter(Collider collider)
    {
        if (isCarryingEgg.value)
        {
            playerDeliveredEgg.Fire();
            heldEgg = collider.GetComponentInChildren<EggzController>();
            totalScore.score += heldEgg.egg.worth;
            Destroy(heldEgg.gameObject);
            isCarryingEgg.value = false;
            Debug.Log("Delivered egg!");
            particleController.PlayParticles();
            returnSoundEffect.Play();
        }
    }
    public int GetScore()
    {
        return totalScore.score;
    }

}
