using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject pause;
    private BallController ballController;
    public void Restart()
    {
        ballController = ball.GetComponent<BallController>();
        ball.transform.position = new Vector3(0, 0, 0);
        ballController.player1Score = 0;
        ballController.player2Score = 0;
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
