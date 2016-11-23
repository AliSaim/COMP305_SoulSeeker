/* Game Title: Soul Seeker
 * File: GameController.cs
 * Students: Taera Kwon (300755802), Ali Saim (300759480)
 * Date Created: 2016-11-22
 * Date Last Modified: 2016-11-22
 * Last Modified By: Taera Kwon
 * Description: Game controller class for Soul Seeker
 * Revision History:
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	[Header("Player")]
	public GameObject Player;

	[Header("Ghosts")]
	public GameObject RedGhost;
	public GameObject BlueGhost;
	public GameObject OrangeGhost;
	public GameObject PinkGhost;

	[Header("UI Labels")]
	public Text LivesLabel;
	public Text SoulsCollectedLabel;
	public Text TotalSoulsCollected;
	public Text GameOverLabel;

	[Header("UI Buttons")]
	public Button RestartButton;
	public Button MainMenuButton;

	// PRIVATE INSTANCE VARIABLES
	private int _playerLives;
	private int _soulsCollected;

	// Use this for initialization
	void Start () 
	{
		this._Initialise ();
	}
	
	// Update is called once per frame
	void Update () 
	{	
	}

	// ACCESSORS
	public int PlayerLives
	{
		get
		{
			return this._playerLives;			
		}
		set 
		{
			this._playerLives = value;
			// If player lives = 0, end game
			if (this._playerLives == 0) 
			{
				this._endGame ();
			}
		}
	}

	public int SoulsCollected
	{
		get
		{
			return this._soulsCollected;
		}
		set 
		{
			this._soulsCollected = value;
		}
	}

	public void RestartGame()
	{
		SceneManager.LoadScene ("Main");
	}


	//
	// PRIVATE METHODS
	//

	// INITIALISE
	private void _Initialise()
	{
		this.GameOverLabel.gameObject.SetActive (false);
		this.TotalSoulsCollected.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (false);
		this.MainMenuButton.gameObject.SetActive (false);
		this._playerLives = 3;
		this._soulsCollected = 0;
		this._Spawn (RedGhost);
		this._Spawn (BlueGhost);
		this._Spawn (OrangeGhost);
		this._Spawn (PinkGhost);
	}

	// SPAWN GHOSTS
	private void _Spawn(GameObject Ghost)
	{
		if (Ghost == RedGhost)
		{
			RedGhost.transform.position = new Vector3 (-0.5257578f, -0.5f, -0.007659912f);
		}
		else if (Ghost == BlueGhost)
		{
			BlueGhost.transform.position = new Vector3 (3.624242f, -0.5f, -0.007659912f);
		}
		else if (Ghost == OrangeGhost)
		{
			OrangeGhost.transform.position = new Vector3 (5.284242f, -0.5f, -0.007659912f);
		}
		else if (Ghost == PinkGhost)
		{
			PinkGhost.transform.position = new Vector3 (-2.115758f, -0.5f, -0.007659912f);
		}
	}

	// End game method
	private void _endGame()
	{
		// Disable 
		this.Player.gameObject.SetActive (false);
		this.RedGhost.gameObject.SetActive (false);
		this.BlueGhost.gameObject.SetActive (false);
		this.PinkGhost.gameObject.SetActive (false);
		this.OrangeGhost.gameObject.SetActive (false);
		this.LivesLabel.gameObject.SetActive(false);

		// Activate
		this.TotalSoulsCollected.gameObject.SetActive(true);
		this.GameOverLabel.gameObject.SetActive (true);
		this.TotalSoulsCollected.gameObject.SetActive (true);
		this.RestartButton.gameObject.SetActive (true);
	}

}
