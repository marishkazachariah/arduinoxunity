using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class CubeMove : MonoBehaviour {

	//player movement. Making it public so it shows on the inspector and can be altered. 
	public float speed; 
	private float amountToMove;


	//reading Arduino from serial port 
	SerialPort sp = new SerialPort("/dev/cu.usbmodem1421", 9600);

	// Use this for initialization
	void Start () {
		sp.Open();
		sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
		amountToMove = speed * Time.deltaTime;

		if (sp.IsOpen) {
			try {
				MoveObject (sp.ReadByte ());
				print (sp.ReadByte ());
			} catch (System.Exception) {

			}
	
		}
	}

	void MoveObject(int direction) {

		if (direction == 1) {
		transform.Translate(Vector3.left * amountToMove, Space.World);
		}
		if (direction == 2) {
		transform.Translate(Vector3.right * amountToMove, Space.World);
		}
	}
}