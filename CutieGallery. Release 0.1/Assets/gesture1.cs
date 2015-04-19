using UnityEngine;
using System.Collections;
using Leap;

public class gesture1 : MonoBehaviour {
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
		controller.Config.SetFloat ("Gesture.Swipe.MinLength", 100.0f);
		controller.Config.SetFloat ("Gesture.Swipe.MinVelocity", 650f);
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

					if(numSelectors > 0){
						numSelectors--;
					}
					if(numSelectors == 9){
						DestroyObject(block1);
					}
					else if(numSelectors == 8){
						DestroyObject(block2);
					}
					else if(numSelectors == 7){
						DestroyObject(block3);
					}
					else if(numSelectors == 6){
						DestroyObject(block4);
					}
					else if(numSelectors == 5){
						DestroyObject(block5);
					}
					else if(numSelectors == 4){
						DestroyObject(block6);
					}
					else if(numSelectors == 3){
						DestroyObject(block7);
					}
					else if(numSelectors == 2){
						DestroyObject(block8);
					}
					else if(numSelectors == 1){
						DestroyObject(block9);
					}
					else if(numSelectors == 0){
						DestroyObject(block10);
					}

					//numSelectors--;
					Debug.Log("left");
					DestroyObject(block1);
				}else if(swipeDirection.x > 0){
					Debug.Log ("Right");
					/*
					numSelectors--;
					if(numSelectors == 10){
						DestroyObject(block1);
					}
					*/

					//DestroyObject(block2);
				}
			}
		}
	}
}
