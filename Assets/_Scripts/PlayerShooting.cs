/* Game Title: Soul Seeker
 * File: GameController.cs
 * Students: Taera Kwon (300755802), Ali Saim (300759480)
 * Date Created: 2016-11-22
 * Date Last Modified: 2016-11-23
 * Last Modified By: Taera Kwon
 * Description: Game controller class for Soul Seeker
 * Revision History:
 *  Nov 23, 2016:
 * 					Added Spawn Methods, Spawn Logics, and Audio Listener
 * 					Added Initialise method, endGame Method
 * 					Added Game Headers for Labels, Ghosts, Player
 *  Nov 22, 2016:	
 * 					Created Game Controller Class
 * 	
 */
using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	//PUBLIC VARIABLES FOR TESTING
	public Transform FlashPoint;
	public GameObject MuzzleFlash;
	public AudioSource RileShotSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame (for Physics)
	void FixedUpdate () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			//Show the MuzzleFlash at the FlashPoint any rotation
			Instantiate (this.MuzzleFlash, this.FlashPoint.position, Quaternion.identity);
			
			//Play Rifle Sound
			this.RileShotSound.Play();
		}
	}
}
