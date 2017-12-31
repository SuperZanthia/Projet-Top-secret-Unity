using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeText_mort : MonoBehaviour {

    void Start()
    {
        //texte de défaîte caché pendant la partie
        gameObject.transform.localScale = new Vector3(0, 0, 0);

    }

    void Update()
    {
        // va chercher si il y a eu collision dans le script Collision_bouche
        Collision_bouche compte = GameObject.Find("FPSController").GetComponent<Collision_bouche>();
        if (compte.mort)
        {
            //affiche le texte et pause le jeu
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            Time.timeScale = 0;
        }
    }
}
