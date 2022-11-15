using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
	public Rigidbody rb;
    public ParticleSystem Partical;
	public PlayerMovment movment;
	public MeshRenderer visible;
	public ParticleSystem winfire1;
	public ParticleSystem winfire2;
	public ParticleSystem winfire3;
	public Vector3 pos;
	public GameObject button;
	public FollowPlayer camermovment;
	public Transform cameraposition;
	public Vector3 camerawinpos;
	public GameObject Text;

	void OnCollisionEnter (Collision ci)
	{
		if (ci.collider.tag == "Obs")
		{
			movment.enabled = false;
			visible.enabled = false;
			Partical.Play();
			rb.velocity = Vector3.zero;
			button.SetActive(true);
		}

		if (ci.collider.tag == "Finish")
		{
			rb.velocity = Vector3.zero;
			movment.enabled = false;
			winfire3.Play();
			winfire2.Play();
			winfire1.Play();
			transform.position = pos;
			rb.useGravity = false;
			rb.AddForce(0,100,0);
			camermovment.enabled = false;
			cameraposition.position = camerawinpos;
			Text.SetActive(true);
		}
			
	}
}
