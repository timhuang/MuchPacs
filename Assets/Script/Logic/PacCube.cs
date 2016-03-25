using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PacCube : MonoBehaviour {

    public float Velocity;

    float _curVelocity;
    Vector3 _curDir;

	// Use this for initialization
	void Start ()
    {
        _curVelocity = 0;
        _curDir = Vector3.zero;
	    if(GUIManager.Instance != null)
        {
            for(int i = 0; i < GUIManager.Instance.HUD_Arrows.Length; i++)
            {
                Button btn = GUIManager.Instance.HUD_Arrows[i];
                if(btn != null)
                {
                    MoveButton dir = btn.GetComponent<MoveButton>();
                    if(dir != null)
                    {
                        dir.RegisterForShiftPosition(OnShiftPosition);
                        dir.RegisterForStopMove(OnStopMovement);
                    }
                }
            }
        }
	}

    void OnDestroy()
    {
        if (GUIManager.Instance != null)
        {
            for (int i = 0; i < GUIManager.Instance.HUD_Arrows.Length; i++)
            {
                Button btn = GUIManager.Instance.HUD_Arrows[i];
                if (btn != null)
                {
                    MoveButton dir = btn.GetComponent<MoveButton>();
                    if (dir != null)
                    {
                        dir.UnregisterForShiftPosition(OnShiftPosition);
                        dir.UnregisterForStopMove(OnStopMovement);
                    }
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 disp = _curVelocity * _curDir * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + disp.x, transform.position.y + disp.y, transform.position.z + disp.z);
	}

    void OnShiftPosition(Vector3 dir)
    {
        _curVelocity = Velocity;
        _curDir = dir;
    }

    void OnStopMovement()
    {
        _curVelocity = 0;
        _curDir = Vector3.zero;
    }

}
