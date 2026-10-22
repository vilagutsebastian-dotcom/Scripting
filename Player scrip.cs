using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Salud del jugador
    private int health = 10;

    //Cantidad de monedas recolectadas
    private int coins;

    //El prefab Fireball y el parámetro Transform del punto de ataque
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //Un método que disminuye la salud del jugador
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    //Método que aumenta la cantidad de monedas
    public void CollectCoins()
    {
        coins++;
        print("Collected coins: " + coins);
    }

    void Update()
    {
        //Si el jugador hace clic izquierdo con el mouse, se crea una bola de fuego
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}