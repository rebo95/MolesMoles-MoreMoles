using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject spawnedObject;
    public int dir;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnedObject.transform.position = this.gameObject.transform.position;
            spawnedObject.transform.forward = dir * this.gameObject.transform.forward;
            GameObject instantiateBullet = Instantiate(spawnedObject);
            Rigidbody instantiateBulletRigidBody = instantiateBullet.GetComponent<Rigidbody>();
            instantiateBulletRigidBody.AddForce(spawnedObject.transform.forward * speed);
        }
    }
}
