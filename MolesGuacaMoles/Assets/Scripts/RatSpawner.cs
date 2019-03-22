using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawner : MonoBehaviour
{
    public GameObject plant;
    public GameObject rat1;
    public GameObject rat2;
    public GameObject rat3;

    GameObject oldRat;


    float timeLeft;
    public int spawnningRateTime = 2;

    PlantLogic plantLogic;

    int plantState = 0;

    int speed = 500;
    
    // Start is called before the first frame update
    void Start()
    {
        plantLogic = plant.GetComponent<PlantLogic>();
        plantState = plantLogic.givePlantState();
        timeLeft = spawnningRateTime;
    }

    // Update is called once per frame
    void Update()
    {
        plantState = plantLogic.givePlantState();
        if(plantState == 1)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                spawnRat(rat1);
                timeLeft = spawnningRateTime;
            }

        }else if (plantState == 2)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                spawnRat(rat2);
                timeLeft = spawnningRateTime;
            }

        }else if (plantState >= 3)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                spawnRat(rat3);
                timeLeft = spawnningRateTime;
            }
        }
    }

    void spawnRat(GameObject rat)
    {

        rat.transform.position = this.gameObject.transform.position;
        rat.transform.forward = this.gameObject.transform.forward;
        GameObject instantiateRat = Instantiate(rat);
        Rigidbody instantiateBulletRat = instantiateRat.GetComponent<Rigidbody>();
        instantiateBulletRat.AddForce(rat.transform.forward * speed);
    }
}
