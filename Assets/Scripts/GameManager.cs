using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float duree;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = duree;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer-= 1* Time.deltaTime;
        }
        if(timer <= 0)
        {
            timer = 0;
        }
    }
}
