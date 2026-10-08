using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnetriggerEnter(Collider other)
    {
     //Cambia la posicion del jugador a la posicion de otro teletransporte
     other.transform.position = teleportPoint.position;   
    }

}
