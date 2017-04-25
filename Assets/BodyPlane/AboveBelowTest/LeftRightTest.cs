using UnityEngine;
using System.Collections;

public class LeftRightTest : MonoBehaviour {
	public Transform target;
	public float dirNum;
	

	void Update () {
		Vector3 heading = target.position - transform.position;
		dirNum = AngleDir(transform.forward, heading, transform.right);

        Debug.DrawLine(transform.position, transform.forward * 10, Color.blue);
        Debug.DrawLine(transform.position, transform.up * 10, Color.red);
        Debug.DrawLine(transform.position, Vector3.Cross(transform.up, transform.forward) * 10, Color.green);

    }


    float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up) {
		Vector3 perp = Vector3.Cross(fwd, targetDir);
		float dir = Vector3.Dot(perp, up);
		
		if (dir > 0f) {
			return 1f;
		} else if (dir < 0f) {
			return -1f;
		} else {
			return 0f;
		}
	}
	
}
