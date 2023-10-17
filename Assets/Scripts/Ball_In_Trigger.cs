using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_In_Trigger : MonoBehaviour
{
    public ParticleSystem endParticle;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            endParticle.Play(true);
        }
    }

    


}
