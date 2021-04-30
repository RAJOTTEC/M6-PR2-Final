using UnityEngine;

public class EndSceneGameBehavior : MonoBehaviour
{
    public GameBehavior _win;
    void Start()
    {
        _win = GameObject.Find("showWinScreen").GetComponent<GameBehavior>();
    }
    void OnGUI()
    {
        if (_win == true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You Win. Click to try again."))
            {
                Utilities.RestartLevel(0);
            }
        }
        else
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "Game Over. Click to try again"))
            {
                Utilities.RestartLevel(0);
            }
        }
    }
}