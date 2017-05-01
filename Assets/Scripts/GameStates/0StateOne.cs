using UnityEngine;
using System.Collections;

namespace GameStates {
	public class StateOne : GameParent
    {
        float angle, ang;
        public StateOne(MonoBehaviour parent) : base(parent) {
            angle = 0;
            cueStick.GetComponent<Renderer>().enabled = true;
        }

		public override void Update() {
            ang = Input.GetAxis("Horizontal");
			
			if (ang != 0) {
				angle = ang * Time.deltaTime * 90;
				gameController.direction = Quaternion.AngleAxis( angle, new Vector3(0,1,0)) * gameController.direction;
				cueStick.transform.RotateAround(cueBall.transform.position, new Vector3(0, 1, 0), angle);
			}

            //If mouse clicked, fire cue stick
			if (Input.GetButtonDown("Fire1")) {
                IncrementState();
			}
		}
	}
}