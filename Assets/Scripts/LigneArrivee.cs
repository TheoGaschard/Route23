using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LigneArrivee : MonoBehaviour
{

    
    // Se trigger lorsque la ligne est franchie
    void OnTriggerEnter2D(Collider2D collided)
    {
        Debug.Log("La ligne d'arrivée est franchie");
        Debug.Log(collided.name);
        
        if (collided.name == "VoitureJoueur")
        {
            Debug.Log("Fin de la partie, changement de scene");
            SceneManager.LoadScene(1);
        }

    }

}
