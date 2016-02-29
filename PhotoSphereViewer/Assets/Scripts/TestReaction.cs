using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class TestReaction : MonoBehaviour {
	private CardboardHead head;
	private Vector3 startingPosition;
	public Object newObj;
	public SpriteRenderer sRender;




	// Use this for initialization
	void Start () {
		startingPosition = transform.localPosition;
		SetGazedAt(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private Vector3 calcRandomDistance() {
		Vector3 direction = Random.onUnitSphere;
		direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
		direction.z = Mathf.Clamp (direction.z, 0.4f, 17f);
		float distance = 2 * Random.value + 1.5f;
		return direction * distance;
	}

	public void CreateNewObject () {
		Vector3 position = calcRandomDistance ();
		Instantiate (newObj, position, Quaternion.identity);
	}

	public void SetGazedAt(bool gazedAt) {
		Debug.Log ("hmmmm");
		if (MouseTarget.instance != null) {
			MouseTarget.instance.TargetChosen (gazedAt);
		} else {
			Debug.Log ("mouse target is null");
		}
		sRender.color = gazedAt ? Color.green : Color.red;
	}
}
