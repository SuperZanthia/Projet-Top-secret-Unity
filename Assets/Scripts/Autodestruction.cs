using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruction : MonoBehaviour {

    //détruit les pommes qui ont été instanciés
    //finalement pas utilisé

	void Start () {
        Destroy(gameObject, 3);
	}
	
}
