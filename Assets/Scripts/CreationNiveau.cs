using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationNiveau : MonoBehaviour
{
    public GameObject Camion;
    private string TrackSave;

    public void Generate()
    {
        // Recupération de la string du niveau
        TrackSave = "A,7.45,-3.10;A,14.4,2.10;A,17.5,0.50";

        // Transformation de la string en tableau
        string[] TrackSaveTab = TrackSave.Split(';');

        // Parcourir le tableau pour créer les objets

        foreach (string ObstacleSave in TrackSaveTab)
        {
            string[] ObstacleSaveTab = ObstacleSave.Split(',');

            string ObstacleType = ObstacleSaveTab[0];
            // float ObstacleX = ObstacleSaveTab[1];
            // float ObstacleY = ObstacleSaveTab[2];

            // Instantiate(Camion, new Vector3(ObstacleX, ObstacleY, 0), Quaternion.identity);

        }


    }


}
