using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {

    [SerializeField] private GameObject pause;
	public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
