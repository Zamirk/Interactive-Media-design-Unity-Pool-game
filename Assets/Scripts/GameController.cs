using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    static public GameController GameInstance { get; set; }

    public Player PlayerOne, PlayerTwo;
    public GameObject cue, cueBall;

    public float maxForce, minForce;
    public Vector3 direction;

    public const float min = 27.5f;
    public const float max = 32f;

    public IState currentState;

    void Start()
    {
        direction = Vector3.forward;
        PlayerOne = new Player();
        PlayerTwo = new Player();

        currentState = new GameStates.StateOne(this);

        GameInstance = this;
    }

    void Update()
    {
        currentState.Update();
    }

    void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

    void LateUpdate()
    {
        currentState.LateUpdate();
    }
}