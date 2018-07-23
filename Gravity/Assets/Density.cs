using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Density {
    float mass { get; set; }
    float density { get; set; }
    float radius { get; set; }
    public Density(GameObject gm)
    {
        mass = gm.GetComponent<Rigidbody>().mass;
        radius = gm.GetComponent<SphereCollider>().radius;
        density = mass / (4 * 3.14f * Mathf.Pow(radius, 2));
    }
    public float GetDensity()
    {
        return density;
    }
    public void SetDensity(float value)
    {
        density = value;
        mass = density * (4 * 3.14f * Mathf.Pow(radius, 2));
    }
    public float GetMass()
    {
        return mass;
    }
    public void SetMass(float value)
    {
        mass = value;
        radius = Mathf.Sqrt(mass / (4 * 3.14f * density));
    }
    public void PlusMass(float value)
    {
        mass += value;
        radius = Mathf.Sqrt(mass / (4 * 3.14f * density));
    }
    public float GetRadius()
    {
        return radius;
    }
    public void SetRadius(float value)
    {
        radius = value;
        mass = density * (4 * 3.14f * Mathf.Pow(radius, 2));
    }
}
