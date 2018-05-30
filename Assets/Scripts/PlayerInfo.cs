using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
public class PlayerInfo : MonoBehaviour {

	public enum PlayerNumeration{ Player1, Player2};

	public string PlayerName;
	public int PlayerScore;
	public PlayerNumeration PlayerNumber;

		void Awake(){
			PlayerName = gameObject.name;
			PlayerScore = 0;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
}