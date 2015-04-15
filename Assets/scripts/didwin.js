#pragma strict
var MenuButons : GameObject;
var LevelsChooser : GameObject;
var chptr1 : GameObject;
var chptr2 : GameObject;
var chptr3 : GameObject;
var chptr4 : GameObject;

var didwin : int = 0;
function Start () {
didwin =(PlayerPrefs.GetInt("didwin"));

if (didwin == 1){
MenuButons.active = false;
LevelsChooser.active = true;

}
else if (didwin < 1){

MenuButons.active = true;
LevelsChooser.active = false;
}
else if (didwin == 2){

chptr2.active = true;
LevelsChooser.active = false;
}
else if (didwin == 3){

chptr3.active = true;
LevelsChooser.active = false;
}
else if (didwin == 4){

chptr4.active = true;
LevelsChooser.active = false;
}






}

function Update () {


}