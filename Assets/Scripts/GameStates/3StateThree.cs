using UnityEngine;
using System;

namespace GameStates {
	public class StrikeState : GameParent
    {
		public StrikeState(MonoBehaviour parent) : base(parent) { 
			var distance2 = (Vector3.Distance(cueStick.transform.position, cueBall.transform.position) - GameController.min) / (GameController.max - GameController.min);
            if (breakIt) {
                force = 100f * (distance2 + 1f) + gameController.minForce;
                breakIt = false;
            } else
            {
                force = 50f * (distance2 + 1f) + gameController.minForce;
            }
        }

		public override void FixedUpdate () {
			var distance = Vector3.Distance(cueStick.transform.position, cueBall.transform.position);
			if (distance < GameController.min) {
				cueBall.GetComponent<Rigidbody>().AddForce(gameController.direction * force);
                IncrementState();
            }
            else {
				cueStick.transform.Translate(cueBall.transform.position - cuePosition);
			}
		}
	}
}