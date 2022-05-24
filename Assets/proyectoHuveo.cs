using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectoHuveo : MonoBehaviour {

    public GameObject eggPrefab;
    public GameObject eggSpawnPoint;
    float tamano = 1; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(eggPrefab);
            clon.transform.position = eggSpawnPoint.transform.position;
            clon.transform.localScale *= 1;
            tamano += 1; 
        }
	}
}
