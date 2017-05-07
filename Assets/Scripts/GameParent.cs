using GameStates;
using UnityEngine;

public abstract class GameParent : IState {
    static public GameParent Game { get; set; }

    //Game states
    enum States { a, b, c, d }
    //Static so it can be used throughout its lifecycle
    static States MyStates;
    protected MonoBehaviour parent;
    protected GameController gameController;
    public static GameObject cueStick;
    public static GameObject win;
    protected static GameObject cueBall;
    protected Rigidbody whiteBallRB;
    public static bool breakIt = true;

    protected static float cueDirection = -1;
    protected float speed = 7;
    protected float speed2 = 30f;
    protected float force = 0f;

    public static Vector3 cuePosition;
    protected static Quaternion cueRotation;

    public GameParent(MonoBehaviour parent) {
		this.parent = parent;
        //Setting the assets
        gameController = (GameController)parent;
        cueBall = gameController.cueBall;
        whiteBallRB = cueBall.GetComponent<Rigidbody>();
        cueStick = gameController.cue;
        States MyStates = States.a;
    }

    public void IncrementState()
    {
        //Change states
        if (MyStates == States.a)
        {
            MyStates = States.b;
            gameController.currentState = new StateTwo(gameController);
            cueStick.GetComponent<Renderer>().enabled = true;
        }
        else if (MyStates == States.b)
        {
            MyStates = States.c;
            gameController.currentState = new StrikeState(gameController);
        }
        else if (MyStates == States.c)
        {
            MyStates = States.d;
			cueStick.GetComponent<Renderer>().enabled = false;
            gameController.currentState = new StateFour(gameController);
        }
        else if (MyStates == States.d)
        {
            MyStates = States.a;
            gameController.currentState = new StateOne(gameController);
        }
    }

    //Reseting cueStick
    public void UpdateCuePosition()
    {
        cueStick.transform.position = cueBall.transform.position - cuePosition;
        cueStick.transform.rotation = cueRotation;
        //cueStick.transform.position.Set(
        //cueStick.transform.position.x + 0.145f,
        //   cueStick.transform.position.y + 1f,
        //   cueStick.transform.position.z + 1.15f);
    }
    public static void UpdateCue()
    {
        cueStick.transform.position = cueBall.transform.position - cuePosition;
        cueStick.transform.rotation = cueRotation;
        //cueStick.transform.position.Set(
        //cueStick.transform.position.x + 0.145f,
        //   cueStick.transform.position.y + 1f,
        //   cueStick.transform.position.z + 1.15f);
    }
    //Update methods
    public virtual void Update() { }
	public virtual void FixedUpdate() { }
	public virtual void LateUpdate() { }
}