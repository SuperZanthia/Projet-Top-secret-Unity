using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compteur_Pommes : MonoBehaviour {

    public bool afficher;

    void Start()
    {
        afficher = false;
    }

  
    void Update () {

        //vérifie qu'il y ai 6 pommes dans l'arbre, sachant que cet objet a déjà 3 enfants (bouche et yeux)

        if (transform.childCount > 8)
        {

            afficher = true;
            

            

           


        }
		
	}
}
