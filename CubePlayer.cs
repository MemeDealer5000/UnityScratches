using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : Cube
{

    private void OnCollisionEnter(Collision other)
    {
        this.HealthPoints = this.HealthPoints - 1;
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(this.HealthPoints);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
}
