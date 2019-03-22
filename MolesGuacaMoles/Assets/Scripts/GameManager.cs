using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instace = null; 
    // Start is called before the first frame update
    void Start()
    {
        instace = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
