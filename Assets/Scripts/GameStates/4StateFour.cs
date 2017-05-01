using UnityEngine;
using System.Collections;

namespace GameStates {
	public class StateFour : GameParent
    {
		public StateFour(MonoBehaviour parent) : base(parent) {
			cuePosition = cueBall.transform.position - cueStick.transform.position;
			cueRotation = cueStick.transform.rotation;
		}

		public override void FixedUpdate() {
            //If the ball comes to a stop, change states
            if (whiteBallRB.velocity == new Vector3(0, 0, 0))
            {
                IncrementState();
            }
        }

		public override void LateUpdate() {
            UpdateCuePosition();
		}
	}
}