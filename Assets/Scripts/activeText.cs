using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeText : MonoBehaviour {

    //pour que le texte de victoire n'apparaissent que si le compteur de pommes a atteint la valeur souhaitée
  
    void Start () {

        //pour cacher le texte pendant la partie
        gameObject.transform.localScale = new Vector3(0, 0, 0);
       
    }

    void Update()
    {
        Compteur_Pommes compte = GameObject.Find("Oak_Tree").GetComponent<Compteur_Pommes>();
        if (compte.afficher == false)
        {
            Time.timeScale = 1;

        }

          // si le compteur de pommes a atteint la valeur souhaitée, le message apparaît et le jeu se pause
        if (compte.afficher)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            Time.timeScale = 0;
        }
    }

}

