using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        Player player = other.GetComponent<Player>();

        //La cantidad de monedas se actualiza
        player.CollectCoins();

        //La moneda que se recolectó se destruye
        Destroy(gameObject);
    }
}