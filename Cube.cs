using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    protected int HealthPoints;
    protected float Velocity;


    // Start is called before the first frame update
    void Start()
    {
        this.Velocity = 2;
        this.HealthPoints = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //doing nothing

    }
}
