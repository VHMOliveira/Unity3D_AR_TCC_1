using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {

    private GameObject target;
    public float range;
    //Declare a raycast hit to store information about what our raycast has hit
    RaycastHit hit;

	// Update is called once per frame
	void Update () {
        ChangeColor();
	}

    void ChangeColor() {
        Vector3 origin = this.transform.position;
        Debug.DrawRay(origin, Vector3.left, Color.green);
            
        if (Physics.Raycast(origin,Vector3.left,out hit,range)) {
            MeshRenderer colorBase = hit.collider.GetComponent<MeshRenderer>();
            colorBase.material.color = Color.red;
        }
    }
}
