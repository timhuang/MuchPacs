using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIManager : MonoBehaviour
{
    private static GUIManager _instance;
    public static GUIManager Instance
    {
        get
        {
            return _instance;
        }
        private set
        {
            _instance = value;
        }
    }

    public enum GameStatus
    {
        ST_MENU = 0,
        ST_CONNECT,
        ST_LOBBY,
        ST_INGAME
    }

    /* hud elements */
    public Text HUD_Status;
    public Button[] HUD_Arrows;

    void Awake()
    {
        GUIManager.Instance = this;
    }

	// Use this for initialization
	void Start ()
    {
	    if(HUD_Status != null)
        {
            HUD_Status.text = GameStatus.ST_INGAME.ToString();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
