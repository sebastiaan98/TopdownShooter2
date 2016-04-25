using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public float health = 100f;
	public float resetAfterDeathTime = 5f;

	private PlayerMovement playermovement;	
	private bool playerDead;
	private float timer;

	void Awake()
	{
		playermovement = GetComponent<PlayerMovement> (); 
	}

	void PlayerDying()
	{
		playerDead = true;
	}
	void PlayerDead()
	{
		playermovement.enabled = false;

	}


	void levelReset()
	{
		
		SceneManager.LoadScene ("MainMenu");
	}

	public void TakeDamage(float amount)
	{
		
		health -= amount;

		if (health <= 0f) 
		{
			if (!playerDead) {
				PlayerDying ();
			}
			else 
			{
				levelReset ();
				PlayerDead ();

			}
		}
	}
}	

