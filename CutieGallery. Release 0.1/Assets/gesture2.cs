using UnityEngine;
using System.Collections;
using Leap;

public class gesture2 : MonoBehaviour {
	Controller controller;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject block6;
	public GameObject block7;
	public GameObject block8;
	public GameObject block9;
	public GameObject block10;


	public int numSelectors = 10;
	public GameObject[] selectorArr;
	public GameObject selector; //selected in the editor
	// Use this for initialization
	void Start () {
		controller = new Controller ();
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		controller.Config.SetFloat ("Gesture.Swipe.MinLength", 200.0f);
		controller.Config.SetFloat ("Gesture.Swipe.MinVelocity", 750f);
		controller.Config.Save ();

		selectorArr = new GameObject[numSelectors];
		for (int i = 0; i < numSelectors; i++) {
			//GameObjectObject go = I
		}
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame ();
		GestureList gestures = frame.Gestures ();
		for (int i = 0; i < gestures.Count; i++) {
			Gesture gesture = gestures[i];
			if(gesture.Type == Gesture.GestureType.TYPESWIPE ){
				SwipeGesture Swipe = new SwipeGesture(gesture);
				//bool moveForward = Input.GetKey(KeyCode.W);
				Vector swipeDirection = Swipe.Direction;
				if(swipeDirection.x < 0){
					Debug.Log("left");
					DestroyObject(block1);
				}else if(swipeDirection.x > 0){
					Debug.Log ("Right");

					
					DestroyObject(block2);
				}
			}
		}
	}
}
