using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        instruction = GetComponent<Text>();
    }
    static public Score ScoreInstance { get; set; }

    public static Text instruction;
    int score_1 = 0;
    int score_2 = 0;
    // Update is called once per frame
    void Update () {
        score_1 = GameController.GameInstance.PlayerOne.points;
        score_2 = GameController.GameInstance.PlayerTwo.points;
        if(score_1 > 7)
        {
            instruction.text = "Player 1 wins!";
        }
        else if (score_2 > 7)
        {
            instruction.text = "Player 2 wins!";
        }
        //var currentPlayer = PoolGameController.GameInstance.CurrentPlayer;
        //var otherPlayer = PoolGameController.GameInstance.OtherPlayer;
        instruction.text = "Player 1: " + score_1 + "\n" + "Player 2: " + score_2;
    }
    public void p2()
    {
        instruction.text = "Player 2 wins";
    }
}
