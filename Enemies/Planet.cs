using UnityEngine;
using System.Collections;

public class Planet : Enemy {
	
	
	
	public void Start() {
		//speedMult = 10;	
	}
	
	
	void FixedUpdate () {
		base.Move();
	}
	
	void OnTriggerEnter(Collider col){
		float temp;
		if(col.tag == "Player"){
			Destroy(gameObject);
		}
		if(col.tag == "Ammo"){
			temp = col.gameObject.GetComponent<Ammo>().GetDamage();
			TakeDamage(temp);
			if(health<=0){
				Destroy(gameObject);
			}
		}
	}
	
	protected override void Scale(){
		float Moscow = gm.GetLaneHeight();
		Vector3 targetScale = new Vector3(Moscow-.1f,Moscow-.1f,Moscow-.1f);
		transform.localScale = targetScale;
	}
	
	
}
