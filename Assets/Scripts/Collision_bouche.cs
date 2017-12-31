using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_bouche : MonoBehaviour
{
    //teste la collision entre le nez de l'arbre (plus la bouche) et le joueur

    public bool mort;

    void Start ()
    {
        mort = false;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "Bouche_arbre")
        {
            mort = true;


        }
    }
}
