using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackBall : MonoBehaviour {
    public Rigidbody rb;
    Vector3 aaa = new Vector3();
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        aaa = rb.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        rb.position = aaa;

        int score_2 = GameController.GameInstance.PlayerTwo.points;
        int score_1 = GameController.GameInstance.PlayerOne.points;

        GameController.GameInstance.PlayerOne.score();
        GameController.GameInstance.PlayerTwo.score();
        rb.angularVelocity = new Vector3(0, 0, 0);
        // Score aaa = Score.ScoreInstance;
        // aaa.p1();
        // } else
        //{
        //Score.ScoreInstance.instruction.text = "Game over";
        // }
        rb.velocity = new Vector3(0, 0, 0);
    }
}
