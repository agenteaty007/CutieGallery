#pragma strict

var redLight : GameObject;

function Start () {
	redLight.SetActive(false);
}

function OnTriggerEnter() {
	redLight.SetActive(true);
}

function OnTriggerExit() {
	redLight.SetActive(false);
}