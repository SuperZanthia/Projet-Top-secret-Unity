using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_terrain : MonoBehaviour {

	
	
	
	void Update () {

        // l'altitude de l'arbre suit celle du terrain

        Vector3 pos = transform.position;
        pos.y = Terrain.activeTerrain.SampleHeight(transform.position);
        transform.position = pos;


    }
}
