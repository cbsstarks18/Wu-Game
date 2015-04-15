#pragma strict
var scoreText:GUIText;
var TotalLifes : int;




// amount of lives you have in the game 
function Update () {
TotalLifes =(PlayerPrefs.GetInt("TotalLifes"));
  scoreText.text = "Lives: " + TotalLifes;
}