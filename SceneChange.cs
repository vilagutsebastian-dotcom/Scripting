using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Nombre de la escena que se debe relanzar
    public string sceneName;

    void OneTriggerEnter()
    {
     //Relanza la escena
     SceneManager.LoadScene(sceneName);  
    }

}
