using UnityEngine;

public class Win : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Utilities.RestartLevel(0);
        }
    }
}
