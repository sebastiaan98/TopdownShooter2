using UnityEngine;
using System.Collections;

public class EnemySpawning : MonoBehaviour {


	public GameObject enemy;
	public Transform spawner; 
	//public float spawnTime;



	void Start () {
		InvokeRepeating("Spawn", 2, 10);
	
		Debug.Log ("teveel");
	
	}



	void Spawn () {
		Instantiate(enemy, spawner.position, spawner.rotation);

			}
}
