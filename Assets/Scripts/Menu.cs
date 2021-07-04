using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  
  private CreationNiveau CreationNiv;

  public void PlayGame()
  {
    
    CreationNiv = new CreationNiveau();

    SceneManager.LoadScene(0);
    Debug.Log("Lancement de la partie");
    CreationNiv.Generate();

  }

}
