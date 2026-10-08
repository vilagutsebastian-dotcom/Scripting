using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    
    void OnTriggerEnter(Collider other)
    {
        //Aumento en la velocidad de correr del jugador
        other.GetComponent<FirstPersonMovement>().runSpeed *=speedFactor;
    }

    // Update is called once per frame
    void OneTriggerExit(Collider other)
    {
       //Disminuir la velocidad de correr del jugador
       other.GetComponent<FirstPersonMovement>().runSpeed/=speedFactor;
    }
}
