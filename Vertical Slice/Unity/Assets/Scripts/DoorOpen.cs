using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour 
{
	private Animator _animator;
	// Use this for initialization
	void Start () 
	{
		_animator = GetComponent<Animator> ();
	}

	//void OnTriggerStay(Collider other)
	//{
	//	if (other.tag == "Player")
	//	{
	//		_animator.SetBool("isOpen", true);
	//	}
	//}

	void Update () 
	{
		if (Input.GetKeyDown ("e")) 
		{
			print ("door should open");
			_animator.SetBool ("isOpen", true);
		}
	}
}
