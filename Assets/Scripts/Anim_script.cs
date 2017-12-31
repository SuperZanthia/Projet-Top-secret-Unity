using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_script : MonoBehaviour {

    public Transform arbre;
    public Transform joueur;

    Animator anim;
	
	void Start () {

        anim = GetComponent<Animator>();

	}

    void Update()
    {
        //si l'arbre est proche du joueur, déclenche l'animation d'attaque, sinon, reste/repasse sur animation de base

        float dist = Vector3.Distance(arbre.position, joueur.position);

        if (dist < 20)
        {
            print(dist);
            anim.SetTrigger("trigger_attack");
        }

        else
        {
            anim.SetTrigger("trigger_stop");
        }
        }
    }

