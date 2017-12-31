using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class Tir : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform origine;
    public int force = 50;

    // Update is called once per frame
    void Update()
    {
        //crée une pomme et déclenche son de tir avec le clic gauche

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instance;
            instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
            instance.AddForce(origine.forward * force);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            


        }
    }
}
