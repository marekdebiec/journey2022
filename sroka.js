


 function OnTriggerEnter2D (other : Collider2D) {
	 if (other.tag == "Player") {
			
	 		
	 		gameObject.GetComponent.<AudioSource>().Play();
	 
			}
	}
	function OnTriggerExit2D (other : Collider2D) {
		if (other.tag == "Player") {
			gameObject.GetComponent.<AudioSource>().Stop();
			
		}
	}
	
	
