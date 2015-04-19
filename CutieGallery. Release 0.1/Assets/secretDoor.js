#pragma strict

var hiddenDoor : GameObject;

function Start () {
	hiddenDoor.SetActive(true);
}

function OnTriggerEnter() {
	hiddenDoor.SetActive(false);
}

function OnTriggerExit() {
	hiddenDoor.SetActive(true);
}