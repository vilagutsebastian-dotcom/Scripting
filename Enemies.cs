using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Velocidad de movimiento del enemigo
    public float speed;

    //El objetivo hacia el cual se mueve el enemigo
    public Transform target;

    //Puntos de daño de un ataque por el enemigo del jugador
    public int playerDamage = 2;

    void Update()
    {
        //Cambia la posición del NPC a una nueva en cada frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //Rota al NPC cada frame para apuntar al objetivo
        transform.LookAt(target.position);
    }

    //Cuando un enemigo choca con un jugador, se inflige daño al segundo jugador
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}