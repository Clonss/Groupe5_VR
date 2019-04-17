using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{

    public Transform pointerObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));    // variable qui reçoit la position de la souris.
        RaycastHit hit;        // variable qui permet de détecter les collision

        if (Physics.Raycast(ray, out hit, 5f)) // On lance un rayon qui part de la camera, qui prend la direction du pointeur de la souris et qui a pour longueur 100.
        {
            pointerObj.position = hit.point;      // Alors on modifie la couleur de la dalle.
        }
    }
}
