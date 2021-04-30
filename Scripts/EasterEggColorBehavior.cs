using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggColorBehavior : MonoBehaviour
{
    Color lerpedColor = Color.white;

    void Update()
    {
        lerpedColor = Color.Lerp(Color.blue, Color.green, Mathf.PingPong(Time.time, 1));
    }
}
