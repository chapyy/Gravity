using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    float G = 6.674f * Mathf.Pow(10.0f, -11.0f);
    public int time;
    Rigidbody rg;
	void Start () {
        rg = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Gravity[] gravities = FindObjectsOfType<Gravity>();
        foreach (Gravity item in gravities)
        {
            if (item != this)
            {
                gravity(item);
            }
        }
    }
    void gravity(Gravity gameObject)
    {
        Rigidbody rigidbody = gameObject.rg;

        Vector3 Direction = transform.position - rigidbody.position;
        float Distance = Direction.magnitude;

        float forceMagnitude = time*G * (rg.mass * rigidbody.mass) / Mathf.Pow(Distance, 2);
        Vector3 force = Direction.normalized * forceMagnitude;

        rigidbody.AddForce(force);
    }
}
