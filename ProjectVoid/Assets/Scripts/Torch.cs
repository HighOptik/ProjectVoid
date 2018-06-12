using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public Light torchLight;
    public float currentLightRange;
    public float maxLightRange;
    public float newLightRange;
    public float smoothspeed;
    
    public bool lightMax;
    public bool lightMin;

    // Use this for initialization
    void Start()
    {
        torchLight = GetComponentInChildren<Light>();
        currentLightRange = torchLight.range;
        smoothspeed = 1f;
        maxLightRange = 5;
        newLightRange = Random.Range(0, maxLightRange);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLightRange <= newLightRange)
        {
            currentLightRange += smoothspeed * Time.deltaTime;
            torchLight.range += smoothspeed *  Time.deltaTime;
        }
        if(currentLightRange == newLightRange)
        {
            newLightRange = Random.Range(0, maxLightRange);

        }
    }
}
