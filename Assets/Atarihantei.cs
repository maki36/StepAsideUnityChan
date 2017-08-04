using UnityEngine;
using System.Collections;



public class Atarihantei : MonoBehaviour {


	//当たり判定を移動させるコンポーネントを入れる（追加）
	//private Rigidbody myRigidbody; 
	//public GameObject unitychan;


	// Use this for initialization
	void Start () {		
		//this.GetComponent<UnityChanController> ();


//		this.myRigidbody.AddForce (this.transform.forward * this.unitychan.forwardForce);
	}
	
	// Update is called once per frame
	void Update () {
	}

	//トリガーモードで他のオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other) {

		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag") {
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "TrafficConeTag") {
			Destroy (other.gameObject);
		}

		//ゴール地点に到達した場合
		if (other.gameObject.tag == "GoalTag") {
		}                

		//コインに衝突した場合
		if (other.gameObject.tag == "CoinTag") {
			//接触したコインのオブジェクトを破棄
			Destroy (other.gameObject);
		}
	}
}
