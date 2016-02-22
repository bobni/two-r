using UnityEngine;
using System.Collections;

public class CameraMovementPhone : MonoBehaviour {
	void Awake () {
		// Check gyro works on this device:
		if (!SystemInfo.supportsGyroscope) {
			Debug.Log ("WARNING: Gyro not supported");
			if (Application.platform != RuntimePlatform.IPhonePlayer ||
				Application.platform != RuntimePlatform.Android) {
				Debug.Log ("WARNING: Gyro only works on phone");
			}
		}

		Input.gyro.enabled = true;    // Enable gyro.
	}

	void Update () {
		// The following code works on Android with the orientation set to "LandscapeLeft"
		// (under "Edit > Player Settings > Player..."). The Android gyro is a little funny and
		// here the z and w values of the quaternion are inverted, and the whole thing effectively
		// rotated up (in pitch) by 90 degrees. For iPhone or for different orientations you'll
		// have to carefully inspect the Euler angles, think about yaw pitch roll, change values
		// and search the internet for a correct solution. Lots of the internet solutions failed
		// for me and Quaterions are hard!
		Quaternion transQuat = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y,
			-Input.gyro.attitude.z, -Input.gyro.attitude.w);
		gameObject.transform.rotation = Quaternion.Euler (90, 0, 0) * transQuat;
		Debug.Log ("transQuat = " + transQuat.eulerAngles.ToString());
	}
}