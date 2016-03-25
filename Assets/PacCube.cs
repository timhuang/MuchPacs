using UnityEngine;
using System.Collections;

public class PacCube : MonoBehaviour {

    const float MOVE_SHIFT = 0.2f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void shift(Vector3 amount)
    {
        transform.position = new Vector3(transform.position.x + amount.x, transform.position.y + amount.y, transform.position.z + amount.z);
    }

    public void MoveLeft()
    {
        shift(new Vector3(-MOVE_SHIFT, 0, 0));
    }

    public void MoveRight()
    {
        shift(new Vector3(MOVE_SHIFT, 0, 0));
    }
    public void MoveUp()
    {
        shift(new Vector3(0, 0, MOVE_SHIFT));
    }
    public void MoveDown()
    {
        shift(new Vector3(0, 0, -MOVE_SHIFT));
    }
}
