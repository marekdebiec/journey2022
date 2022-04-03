//var SpawnPoint : Transform;
 //var respawn : boolean = false;
 //var PlayerLife : int;
var Player : GameObject;
// var serce : GameObject; 
// private var aa : GameObject;
// private var bb : GameObject;
// private var cc : GameObject;
// var isTrue : boolean;
// var expression = "arbuz";
// var aa;
// var bb; 
// var cc;
// private var yetAnotherScript3 : Platformer2DUserControl;
 var rigidbdy : Rigidbody2D;
 
 function Start () {
	
 	Player = GameObject.FindWithTag ("baloon");
 	rigidbdy = Player.GetComponent(Rigidbody2D) ;
 }
 function Update () {
 	//serce = GameObject.FindWithTag("heart");
// 	aa = GameObject.Find("a");
// 	bb = GameObject.Find("b");
// 	cc = GameObject.Find("c");
		// if (serce == null) {
					//	Application.LoadLevel ("game_over");
						
				//	}
 }
// function Update () {
// 
//    if(PlayerLife <= 0)
//    {
//    respawn = true;
//    }
//    else
//    {
//    respawn = false;
//    }
// 
//     if(respawn)
//     {
// 
//     Player.transform.position = SpawnPoint.position;
// 
//     }
// }
 function OnTriggerEnter2D (other : Collider2D) {
	 if (other.tag == "baloon") {
			rigidbdy.isKinematic = false;
			//yetAnotherScript3 =  player.GetComponent(Platformer2DUserControl);
			//yetAnotherScript3.enabled = false;
	 		//other.GetComponent.<AudioSource>().Play();
	 		gameObject.GetComponent.<AudioSource>().Play();
	 		Destroy (this);
	 		//Destroy ( serce );
//	 		if (aa != null) 
//	 			{
//	 				Destroy(aa);
//	 			}
//	 		else if (bb != null) {
//	 			Destroy (bb);
//	 			}
//	 		else if (cc != null) {
//	 			Destroy (cc);
//	 			Application.LoadLevel("game_over");
//	 			}
//	 		else if (cc == null) {
//	 			Application.LoadLevel("game_over");
//	 			}
	 		
	 		
//	 		switch (expression ) {
//	 			case "Pomarancze":
//	 				Destroy.aa;
//	 				break;
//	 				case "arbuz":
//	 				Destroy.bb;
//	 				break;
//	 				case "mandarynka":
//	 				Destroy.cc;
//	 				break;
//	 				default:
//	 				isTrue = true;
//	 		}
	 		//if (serce == null) {
				//Application.LoadLevel ("game_over");
				
			//}
//			if (SpawnPoint != null) {
//			 Player.transform.position = SpawnPoint.position;
//			 }
			
			}
	}
	
	
