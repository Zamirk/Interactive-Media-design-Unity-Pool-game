using UnityEngine;
using System.Collections;

namespace GameStates {
	public class StateTwo : GameParent
    {
		public StateTwo(MonoBehaviour parent) : base(parent) {
            distance = 0;
        }
        float distance;

        public override void Update() {
			if (Input.GetButtonUp("Fire1")) {
                IncrementState();
			}
		}
        bool stickDirectionBack = true;
        
		public override void FixedUpdate () {
            //Calculation cue stick distance
			distance = Vector3.Distance(
                cueStick.transform.position,
                cueBall.transform.position);

            //Move stick
            Move();
        }

        public void Move()
        {
            //Moving stick back and forth
            if (stickDirectionBack)
            {
                cueStick.transform.Translate(Vector3.forward * Time.fixedDeltaTime * 0.2f);
                //If the stick reaches the limit, change direction
                if (distance > 1f)
                {
                    stickDirectionBack = false;
                }
            }
            else if (!stickDirectionBack)
            {
                cueStick.transform.Translate(Vector3.back * Time.fixedDeltaTime * 0.2f);
                //If the stick reaches the limit, change direction
                if (distance < .8f)
                {
                    stickDirectionBack = true;
                }
            }
        }
	}
}