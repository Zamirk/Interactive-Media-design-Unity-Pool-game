using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Player {

    //Player object
	public Player() {
        points = 0;
    }

    //Points for game
    public int points { get; set; }

    public void score()
    {
        points++;
    }
}
