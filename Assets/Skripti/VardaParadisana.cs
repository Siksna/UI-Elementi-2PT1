using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
/* FPS SKAITITAJS
 * int kadrs=0;
	// Use this for initialization
	void Start () {
		Debug.Log ("Starteta programma");
	}
	
	// Update is called once per frame
	void Update () {
		kadrs++;
		Debug.Log ("Kadrs: "+kadrs);
	}*/



	//Mainígais, kurá ieglabás tekstu no input field
	private string teksts;
	private string[] varianti = {"Sveiki ","Atā ","Uz redzēšanos ","Adios ","Jauku dienu ","Prieks tevi redzēt "};
	//Uzglaba random nogenereto skaitli
	int nejausais;
	//Lauks no kura ievada tekstu
	public GameObject ievadesLauks;
	//Text kura attelos tekstu
	public GameObject tekstaAttelosana;

	public void UzglabatTekstu(){
		nejausais = Random.Range (0,varianti.Length);
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text> ().text = varianti [nejausais]+teksts.ToUpper()+"!";
	}
}
