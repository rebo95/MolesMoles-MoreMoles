using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLogic : MonoBehaviour
{
    int plantState = 0;
    // Start is called before the first frame update
    public bool increase = false;

    public GameObject fase2;
    public GameObject fase3;


    float timeLeft;
    public int growingTime = 3;

    private void Start()
    {
        timeLeft = growingTime;

        fase2.SetActive(false);
        fase3.SetActive(false);
    }

    void increasePlantState()
    {
        plantState++;
    }

    void increasePlantStateCaller()
    {
        increasePlantState();
        Invoke("increasePlantStateCaller", 3.0f);
    }

    public int givePlantState()
    {
        return plantState;
    }


    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            increasePlantState();
            timeLeft = growingTime;
        }

        if(plantState == 2)
        {
            fase2.SetActive(true);
        }

        if(plantState == 3)
        {
            fase3.SetActive(true);
        }
    }


}
