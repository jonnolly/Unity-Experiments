using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameController : MonoBehaviour
    {
		public Text Player1Score;
		public Text Player2Score;
		public GameObject Player1;
		public GameObject Player2;

		private Vector3 _startLocationPlayer1;
		private Vector3 _startLocationPlayer2;


		// Use this for initialization
		void Start()
		{
			var infoPlayer1 = Player1.GetComponent<PlayerInfo> ();
			var infoPlayer2 = Player2.GetComponent<PlayerInfo> ();
			Player1Score.text = PlayerScoreText (infoPlayer1);
			Player2Score.text = PlayerScoreText (infoPlayer2);
		}

		public void UpdatePlayerScore(PlayerInfo playerInfo)
		{
			if (playerInfo != null) {
				string playerScoreText = PlayerScoreText (playerInfo);
				switch (playerInfo.PlayerNumber) {
				case PlayerInfo.PlayerNumeration.Player1:
					Player1Score.text = playerScoreText;
					break;
				case PlayerInfo.PlayerNumeration.Player2:
					Player2Score.text = playerScoreText;
					break;
				};
			}
		}
			
		private string PlayerScoreText(PlayerInfo playerInfo)
		{
			return playerInfo.PlayerName + " score: " + playerInfo.PlayerScore;
		}

        public void RespawnPlayers()
		{
			// todo: Implement respawn
        }
    }
}
