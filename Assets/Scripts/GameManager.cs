using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
    public BoardManager boardScript;

	public int playerFoodPoints = 100;
	[HideInInspector] public bool playersTurn = true;
    private int level = 3;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		}
		else if (instance != this ) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

        boardScript = GetComponent<BoardManager>();
        InitGame();
	}

	public void GameOver()
	{
		enabled = false;
	}
	
    void InitGame()
    {
        boardScript.SetupScene(level);
    }

	// Update is called once per frame
	void Update () {
	
	}


}
