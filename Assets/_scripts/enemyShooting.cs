using UnityEngine;
using System.Collections;

public class enemyShooting : MonoBehaviour 
{
	public float maximumDamage = 120f;                  
	public float minimumDamage = 45f;                   

	private SphereCollider col;                         
	private Transform player;                           
	private PlayerHealth playerHealth;                  
	private bool shooting;                              
	private float scaledDamage; 

	public float bulletspeed;
	public float shootRate;
	public Projectile projectile;
	public Transform muzzle; 

	private float nextFireTime;

	void Start()
	{
		nextFireTime = 0;
	}

	void Awake()
	{

	col = GetComponent<SphereCollider>();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.gameObject.GetComponent<PlayerHealth> ();

		scaledDamage = maximumDamage - minimumDamage;


	
	}


	void Update()
	{
		if ( (Time.time >= nextFireTime))

		{
			shoot ();

		}
	}
	private void shoot()
	{
		Projectile bullet =  Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		bullet.SetSpeed (bulletspeed);
		nextFireTime = Time.time + shootRate;
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {

			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

}