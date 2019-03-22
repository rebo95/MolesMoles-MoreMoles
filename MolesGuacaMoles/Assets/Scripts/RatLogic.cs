using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Plant")
        {
            Invoke("order66", 2.0f);
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            order66();
        }
    }

    void order66()
    {
        Destroy(gameObject);
    }
}
