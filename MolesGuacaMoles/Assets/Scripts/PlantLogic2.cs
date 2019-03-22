using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLogic2 : MonoBehaviour
{
    // Start is called before the first frame update
    int plantState = 0;
    // Start is called before the first frame update
    public bool increase = false;

    SpriteRenderer spriteRenderer;

    public Sprite stage1;
    public Sprite stage2;
    public Sprite stage3;


    float timeLeft;
    public int growingTime = 3;

    private void Start()
    {
        timeLeft = growingTime;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = stage1;
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



        if (plantState <= 1)
        {
            spriteRenderer.sprite = stage1;

        }

        if (plantState == 2)
        {
            spriteRenderer.sprite = stage2;

        }

        if (plantState == 3)
        {

            spriteRenderer.sprite = stage3;
        }
    }

}
