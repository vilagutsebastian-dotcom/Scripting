using UnityEngine;

public class NPC : MonoBehaviour
{
    // Salud del NPC
    public int health = 5;

    // Nivel del NPC (añadido para que la suma funcione)
    public int level = 1;

    // Velocidad NPC
    public float speed = 1.2f;

    void Start()
    {
        // Suma el nivel al valor actual de la salud al inicio del juego
        health += level;

        // Muestra el valor actualizado de health en la consola (Corregido: Debug.Log)
        Debug.Log(health);
    }

    void Update()
    {
        // 1. Crear la variable newPosition y asignarle la posición actual del objeto
        Vector3 newPosition = transform.position;

        // 2. Cambiar la posición en el eje Z según la velocidad y el tiempo transcurrido
        newPosition.z += speed * Time.deltaTime;

        // 3. Asignar el valor actualizado de newPosition a la propiedad transform.position
        transform.position = newPosition;
    }
}