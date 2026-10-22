using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //Velocidad de vuelo de la bola de fuego[cite: 7]
    public float speed;[cite: 7]

    void Update()
    {
        //El clon de bola de fuego se destruye después de 3 segundos[cite: 7]
        Destroy(gameObject, 3);[cite: 7]

        //En cada frame, la posición de la bola se actualiza mediante el producto del vector de movimiento hacia delante (0, 0, 1),[cite: 7]
        //la velocidad de la bola y el valor de la diferencia, en segundos, entre el último frame y el actual[cite: 7]

        transform.position += transform.forward * speed * Time.deltaTime;[cite: 7]
    }

    void OnTriggerEnter(Collider other) {[cite: 7]

        //El enemigo se destruye[cite: 7]
        Enemy enemy = other.GetComponent<Enemy>();[cite: 7]
        Destroy(enemy.gameObject);[cite: 7]

        //El proyectil se destruye[cite: 7]
        Destroy(gameObject);[cite: 7]

    }
}