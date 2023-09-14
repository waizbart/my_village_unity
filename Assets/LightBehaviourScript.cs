using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviourScript : MonoBehaviour { 

    public Light Sun;

    void Update()
    {
        Sun.transform.Rotate(5f * Time.deltaTime, 0, 0);
    }
}
