#pragma strict
var scoreText:GUIText;
var scoreText2:GUIText;
var scoore:int = 1;
var unlocklvl :int = 0;
var keys : int = 0;

private var didwin :int = 0;

var CountCollect :int;
var FinallAmount :int;
var LevelUnl :int;
var anim : Animator;

  function Start (){
//  PlayerPrefs.SetInt("scoore");
scoore =(PlayerPrefs.GetInt("LevelUnl"));
  anim = GetComponent("Animator");
  }

  
function Update () {
if (keys == FinallAmount) {
anim.SetInteger("win", 1);

rigidbody2D.mass = 999;
LevelUnl = unlocklvl;
didwin = 1;
//score =(PlayerPrefs.GetInt("LevelUnl"));
//PlayerPrefs.SetInt("playerScoore", scoore);
PlayerPrefs.SetInt("LevelUnl", LevelUnl);
PlayerPrefs.SetInt("didwin", didwin);

Delay ();
 
 }
    scoreText.text = "Collected: " + keys;
  //  scoreText2.text =  "/" + FinallAmount;

}

function OnTriggerEnter2D(hitcoint2: Collider2D) {
//if (hitcoint.gameObject.tag == "coint"){
if (hitcoint2.tag == "coint"){
 scoore += 1;
 
 }
//Destroy (other.gameObject);
else if (hitcoint2.tag == "key"){
keys += 1;
 //scoore += 10;

}


}


function Delay (){
yield WaitForSeconds (3);
Application.LoadLevel ("menu1");


}
