#pragma strict

function Start () {

}

var remains: GameObject;
function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.tag == "hand")
    {
     	 Instantiate(remains, transform.position, transform.rotation);
         //Destroy(gameObject);
    }
}