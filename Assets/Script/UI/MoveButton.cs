using UnityEngine;
using System.Collections;

public class MoveButton : MonoBehaviour
{
    public enum Direction
    {
        UP = 0,
        LEFT,
        DOWN,
        RIGHT
    }

    /// <summary>
    /// direction enum
    /// </summary>
    public Direction MyDirection;

    public delegate void OnMovePlayer(Vector3 dir);

    private event OnMovePlayer _shiftPosition = delegate { };

    public void RegisterForShiftPosition(OnMovePlayer handler)
    {
        _shiftPosition += handler;
    }

    public void UnregisterForShiftPosition(OnMovePlayer handler)
    {
        _shiftPosition -= handler;
    }

    public delegate void OnStopPlayer();

    private event OnStopPlayer _stopMovement = delegate { };

    public void RegisterForStopMove(OnStopPlayer handler)
    {
        _stopMovement += handler;
    }

    public void UnregisterForStopMove(OnStopPlayer handler)
    {
        _stopMovement -= handler;
    }

    Vector3 dir;

	// Use this for initialization
	void Start ()
    {
	    switch(MyDirection)
        {
            case Direction.UP:
                dir = new Vector3(0, 0, 1);
                break;
            case Direction.LEFT:
                dir = new Vector3(-1, 0, 0);
                break;
            case Direction.DOWN:
                dir = new Vector3(0, 0, -1);
                break;
            case Direction.RIGHT:
                dir = new Vector3(1, 0, 0);
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
	}

    public void OnMouseDown()
    {
        _shiftPosition(dir);
    }

    public void OnMouseUp()
    {
        _stopMovement();
    }
}
