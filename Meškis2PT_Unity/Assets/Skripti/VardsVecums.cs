using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardsVecums : MonoBehaviour {

	public string teksts;
	public string teksts2;
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		teksts2 = ievadesLauks2.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text=teksts+" ir "+teksts2+" gadus vecs!";
	}

}
