using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject Cements;
	public GameObject BMW;
	public GameObject Ekskavators;
	public GameObject Policija;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject Ugunsdzēsējs;

	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 bmwKoord;
	[HideInInspector]
	public Vector2 ekskavaKoord;
	[HideInInspector]
	public Vector2 policijasKoord;
	[HideInInspector]
	public Vector2 T1Koord;
	[HideInInspector]
	public Vector2 t5Koord;
	[HideInInspector]
	public Vector2 ugunsKoord;







	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = b2.GetComponent<RectTransform> ().localPosition;
		b2Koord = Cements.GetComponent<RectTransform> ().localPosition;
		cementKoord = BMW.GetComponent<RectTransform> ().localPosition;
		bmwKoord = Ekskavators.GetComponent<RectTransform> ().localPosition;
		ekskavaKoord = Policija.GetComponent<RectTransform> ().localPosition;
		policijasKoord = Traktors1.GetComponent<RectTransform> ().localPosition;
		T1Koord = Ugunsdzēsējs.GetComponent<RectTransform> ().localPosition;
		t5Koord = Traktors5.GetComponent<RectTransform> ().localPosition;
		ugunsKoord = Traktors5.GetComponent<RectTransform> ().localPosition;

	}
}
