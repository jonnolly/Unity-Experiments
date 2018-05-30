using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;
using System;

public class ColliderScript : MonoBehaviour
{
    // todo:
    //  *   Find way to only have one bullet prefab & dynamically retrieve the player name from the bullet owner

	public GameObject ParentPlayer;

    public string PlayerName;
    public string EnemyName;
    public Text PlayerScore;
    private GameController _gameController;
	private PlayerInfo _parentPlayerInfo;

    // Use this for initialization
    void Start()
    {
        var gameControllerObject = GameObject.Find("GameController");
        _gameController = gameControllerObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
	{
		if(_parentPlayerInfo == null)
			_parentPlayerInfo = ParentPlayer.GetComponent<PlayerInfo> ();
    }

    void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.name != PlayerName && collision.gameObject.name != "Player1BulletPrefab(Clone)" && collision.gameObject.name != "Player2BulletPrefab(Clone)")
        {
            Destroy(collision.gameObject);
			if (collision.gameObject.name.Contains (EnemyName)) {
				if (_parentPlayerInfo != null) {
					_parentPlayerInfo.PlayerScore++;
					_gameController.UpdatePlayerScore (_parentPlayerInfo);
					_gameController.RespawnPlayers ();
				}
			}
        }
    }
}
