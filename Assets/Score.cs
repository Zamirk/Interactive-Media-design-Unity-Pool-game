using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
    Text instruction;
    int score_1 = 0;
    int score_2 = 0;
    // Update is called once per frame
    void Update () {
        instruction = GetComponent<Text>();
        score_1 = GameController.GameInstance.PlayerOne.points;
        score_2 = GameController.GameInstance.PlayerTwo.points;

        //var currentPlayer = PoolGameController.GameInstance.CurrentPlayer;
        //var otherPlayer = PoolGameController.GameInstance.OtherPlayer;
        instruction.text = "Player 1: " + score_1 + "\n" + "Player 2: " + score_2;
    }
}
