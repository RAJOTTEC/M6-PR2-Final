using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonBehavior : MonoBehaviour
{
    public GameBehavior gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item collected!");
            collision.gameObject.GetComponent<PlayerBehavior>().moveSpeed /= 2f;
            gameManager.Items += 1;
            gameManager.HP -= 1;
            gameManager.PrintLootReport();
        }
    }
}