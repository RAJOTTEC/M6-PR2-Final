using UnityEngine;

public class Lose : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Utilities.RestartLevel(0);
        }
    }
}
