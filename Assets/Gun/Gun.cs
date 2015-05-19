using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {


	public GameObject bulletPrefab;
	public float initialVelocity;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;


			var screenPoint = Input.mousePosition;
			screenPoint.z = 10;

			Camera camera = GetComponent<Camera>();
			var worldPoint = camera.ScreenToWorldPoint(screenPoint);




			//Vector3 direction = transform.forward;
			Vector3 direction = (worldPoint - transform.position).normalized;


			rb = bullet.GetComponent<Rigidbody>();
			rb.velocity = direction * initialVelocity;
		}
	}
}
