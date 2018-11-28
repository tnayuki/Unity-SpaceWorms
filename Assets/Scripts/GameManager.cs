using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;

	public Text title;
	public Text winner;

	IEnumerator Start() {
		for (;;) {
			if (Input.GetButtonDown("Player1_Fire") || Input.GetButtonDown("Player2_Fire")) {
				break;
			}
	
			yield return null;
		}

		title.enabled = false;

		player1.SetActive(true);
		player2.SetActive(true);

		for (;;) {
			if (player1.transform.childCount == 1) {
				winner.enabled = true;
				winner.text = "Player 2 WIN";	

				break;
			} else if (player2.transform.childCount == 1) {
				winner.enabled = true;
				winner.text = "Player 1 WIN";

				break;
			}
	
			yield return null;
		}

		yield return new WaitForSeconds(3.0f);

		SceneManager.LoadScene(0);

		yield return null;
	}
}
