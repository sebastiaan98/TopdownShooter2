using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 	
	{
	
	public Projectile projectile;
	public Transform muzzle; 
	public float bulletspeed;
	public float shootRate;
	private float bullets = 7;
	private float ammoLeft = 200;
	private float delaycounter = 0.0f;
	private float reloadDelay = 1f;
	private float nextFireTime;

	void Start()
	{
		nextFireTime = 0;
	}

	void Update()
	{
		if (Input.GetMouseButton (0) && (Time.time >= nextFireTime) && bullets > 0) {
			shoot ();
		}
		else if (Input.GetKeyDown ("r") && ammoLeft > 0 && bullets < 7) 
		{
			bullets = 7;
			delaycounter = Time.time + reloadDelay;
		}	

	}
	private void shoot()
	{
		Debug.Log (muzzle);
		Projectile bullet =  Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		bullet.SetSpeed (bulletspeed);
		nextFireTime = Time.time + shootRate;
		bullets -= 1;
	}
}