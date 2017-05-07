using UnityEngine;
using System;

namespace GameStates
{
    public class StrikeState : GameParent
    {
        public StrikeState(MonoBehaviour parent) : base(parent)
        {
            //Finding the percent of distance between the ball and the cue stick
            //Varies from 0 to 1 after maths
            var distance2 = -(1 - (5 * (2 - ((Vector3.Distance(cueStick.transform.position, cueBall.transform.position) + 1f)))));
            Debug.Log(distance2);

            if (breakIt)
            {
                force = (distance2 * 650);
                breakIt = false;
            }
            else
            {
                force = (distance2 * 400);
            }
        }

        public override void FixedUpdate()
        {
            var distance = Vector3.Distance(cueStick.transform.position, cueBall.transform.position);
            if (distance < GameController.min)
            {
                cueBall.GetComponent<Rigidbody>().AddForce(gameController.direction * force);
                IncrementState();
            }
            else
            {
                cueStick.transform.Translate(cueBall.transform.position - cuePosition);
            }
        }
    }
}