﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Gameover : MonoBehaviour {

	public Text numWaves;
	public Text expGained;

	//Set the number of waves reached in the gameover screen
	void OnEnable(){
		numWaves.text = gameStats.waves.ToString();
		expGained.text = Mathf.CeilToInt(gameStats.waves * gameStats.enemyDiff * gameStats.mapDiff).ToString ();
	}

	//Reload level
	public void Retry(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	//Go to the main menu
	public void ToMenu(){
		SceneManager.LoadScene(0);
	}

}