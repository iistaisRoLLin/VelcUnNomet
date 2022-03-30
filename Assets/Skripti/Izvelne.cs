using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Importē lai varētu ielādēt ainas
using UnityEngine.SceneManagement;

public class Izvelne : MonoBehaviour {

	// Lai ar pogas nospiešanu mainītos uz galveno ainu
	public void uzGalveno(){
		SceneManager.LoadScene ("Pilseta", LoadSceneMode.Single);

	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
