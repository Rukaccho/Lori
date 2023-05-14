using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public new ParticleSystem particleSystem;

    private void Start()
    {
       
        particleSystem.Stop();
    }

    public void PlayParticles()
    {
   
        particleSystem.Play();
    }
}
