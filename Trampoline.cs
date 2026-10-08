using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    
    void OneTriggerEnter(Collider other)
    {
     //Aumento de fuerza de salto
     other.GetComponent<Jump>().jumpStrength = 2;  
    }

}
