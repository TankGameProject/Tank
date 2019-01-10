using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowGameObject : MonoBehaviour {

	[SerializeField]
	GameObject targetToFollow;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (targetToFollow.transform.position.x,targetToFollow.transform.position.y,targetToFollow.transform.position.z-10f);
	}
}
