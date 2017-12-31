using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collision_pomme : MonoBehaviour
{
    public GameObject parti;
    public GameObject instance;
    
    

    void OnCollisionEnter(Collision col)
    {

        //si collision entre pomme et arbre, annule physique de la pomme et l'attache à l'arbre
        // hauteur définie pour que les pommes ne s'attachent qu'aux branches et pas au tronc

        if (col.gameObject.name == "Oak_Tree" && gameObject.transform.position.y > 7)
        {
            
            Destroy(obj: GetComponent<Rigidbody>());

            transform.parent = GameObject.Find("Oak_Tree").transform;


        }

        //détruit la pomme quand elle touche un mur

        if (col.gameObject.tag == "Cube")

        {

            GameObject instance = Instantiate(parti, transform.position, Quaternion.identity) as GameObject;
            Destroy(gameObject);
        }

    }

}
