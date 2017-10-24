using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadNormal : MonoBehaviour {

    RaycastHit hit;
    Ray ray = new Ray(new Vector3(0,0,0), Vector3.down);
    float step;
	
	// Update is called once per frame
	void Update () {
        step = 100 * Time.deltaTime;
		if(Physics.Raycast(ray, out hit)) {
            if(hit.collider.tag == "Terrain") {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(hit.normal), step);
            }
        }
	}
}
