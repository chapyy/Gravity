using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour {
    float density_;
    float mass_;
    float radius_;

    Density density;
    Rigidbody rg;
	void Start () {
        density = new Density(gameObject);
        rg = GetComponent<Rigidbody>();
	}
	
	void Update () {
        density.SetMass(4);
        transform.localScale = new Vector3(density.GetRadius() * 2, density.GetRadius() * 2, density.GetRadius() * 2);
        rg.mass = density.GetDensity();
    }
}
