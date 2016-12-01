using UnityEngine;
using System.Collections;
using Vuforia;
//[RequireComponent(typeof(AudioSource))]
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject CButton;
	private GameObject DButton;
	private GameObject EButton;
	private GameObject FButton;
	private GameObject GButton;
	private GameObject AButton;
	private GameObject BButton;
	private GameObject C4Button;

	private GameObject D4Button;
	private GameObject E4Button;
	private GameObject F4Button;
	private GameObject G4Button;
	private GameObject A4Button;
	private GameObject B4Button;
	private GameObject C5Button;

	private GameObject Csharp3Button;
	private GameObject Dsharp3Button;
	private GameObject Fsharp3Button;
	private GameObject Gsharp3Button;
	private GameObject Asharp3Button;

	private GameObject Csharp4Button;
	private GameObject Dsharp4Button;
	private GameObject Fsharp4Button;
	private GameObject Gsharp4Button;
	private GameObject Asharp4Button;

	private GameObject Song1_Button;
	private GameObject Song2_Button;

	public AudioSource C3;
	public AudioSource D3;
	public AudioSource E3;
	public AudioSource F3;
	public AudioSource G3;
	public AudioSource A3;
	public AudioSource B3;
	public AudioSource C4;

	public AudioSource D4;
	public AudioSource E4;
	public AudioSource F4;
	public AudioSource G4;
	public AudioSource A4;
	public AudioSource B4;
	public AudioSource C5;

	public AudioSource Csharp3;
	public AudioSource Dsharp3;
	public AudioSource Fsharp3;
	public AudioSource Gsharp3;
	public AudioSource Asharp3;

	public AudioSource Csharp4;
	public AudioSource Dsharp4;
	public AudioSource Fsharp4;
	public AudioSource Gsharp4;
	public AudioSource Asharp4;

	public GameObject C3_LightObj;
	public Light C3_Light;
	public GameObject D3_LightObj;
	public Light D3_Light;
	public GameObject E3_LightObj;
	public Light E3_Light;
	public GameObject F3_LightObj;
	public Light F3_Light;
	public GameObject G3_LightObj;
	public Light G3_Light;
	public GameObject A3_LightObj;
	public Light A3_Light;
	public GameObject B3_LightObj;
	public Light B3_Light;

	public GameObject C4_LightObj;
	public Light C4_Light;
	public GameObject D4_LightObj;
	public Light D4_Light;
	public GameObject E4_LightObj;
	public Light E4_Light;
	public GameObject F4_LightObj;
	public Light F4_Light;
	public GameObject G4_LightObj;
	public Light G4_Light;
	public GameObject A4_LightObj;
	public Light A4_Light;
	public GameObject B4_LightObj;
	public Light B4_Light;

	public GameObject C5_LightObj;
	public Light C5_Light;

	public GameObject Csharp3_LightObj;
	public Light Csharp3_Light;
	public GameObject Dsharp3_LightObj;
	public Light Dsharp3_Light;
	public GameObject Fsharp3_LightObj;
	public Light Fsharp3_Light;
	public GameObject Gsharp3_LightObj;
	public Light Gsharp3_Light;
	public GameObject Asharp3_LightObj;
	public Light Asharp3_Light;

	public GameObject Csharp4_LightObj;
	public Light Csharp4_Light;
	public GameObject Dsharp4_LightObj;
	public Light Dsharp4_Light;
	public GameObject Fsharp4_LightObj;
	public Light Fsharp4_Light;
	public GameObject Gsharp4_LightObj;
	public Light Gsharp4_Light;
	public GameObject Asharp4_LightObj;
	public Light Asharp4_Light;
	// Use this for initialization
	void Start () {

		CButton = GameObject.Find ("CButton");  // Finds the Virtual Button Object
		DButton = GameObject.Find ("DButton");  // Finds the Virtual Button Object
	    EButton = GameObject.Find ("EButton");  // Finds the Virtual Button Object
	    FButton = GameObject.Find ("FButton");  // Finds the Virtual Button Object
	    GButton = GameObject.Find ("GButton");  // Finds the Virtual Button Object
	    AButton = GameObject.Find ("AButton");  // Finds the Virtual Button Object
	    BButton = GameObject.Find ("BButton");  // Finds the Virtual Button Object
		C4Button = GameObject.Find ("C4Button");  // Finds the Virtual Button Object

		D4Button = GameObject.Find ("D4Button");  // Finds the Virtual Button Object
		E4Button = GameObject.Find ("E4Button");  // Finds the Virtual Button Object
		F4Button = GameObject.Find ("F4Button");  // Finds the Virtual Button Object
		G4Button = GameObject.Find ("G4Button");  // Finds the Virtual Button Object
		A4Button = GameObject.Find ("A4Button");  // Finds the Virtual Button Object
		B4Button = GameObject.Find ("B4Button");  // Finds the Virtual Button Object
		C5Button = GameObject.Find ("C5Button");  // Finds the Virtual Button Object

		Csharp3Button = GameObject.Find ("Csharp3Button");  // Finds the Virtual Button Object
		Dsharp3Button = GameObject.Find ("Dsharp3Button");  // Finds the Virtual Button Object
		Fsharp3Button = GameObject.Find ("Fsharp3Button");  // Finds the Virtual Button Object
		Gsharp3Button = GameObject.Find ("Gsharp3Button");  // Finds the Virtual Button Object
		Asharp3Button = GameObject.Find ("Asharp3Button");  // Finds the Virtual Button Object

		Csharp4Button = GameObject.Find ("Csharp4Button");  // Finds the Virtual Button Object
		Dsharp4Button = GameObject.Find ("Dsharp4Button");  // Finds the Virtual Button Object
		Fsharp4Button = GameObject.Find ("Fsharp4Button");  // Finds the Virtual Button Object
		Gsharp4Button = GameObject.Find ("Gsharp4Button");  // Finds the Virtual Button Object
		Asharp4Button = GameObject.Find ("Asharp4Button");  // Finds the Virtual Button Object

		Song1_Button = GameObject.Find ("Song1_Button");
		Song2_Button = GameObject.Find ("Song2_Button");



		AudioSource C3 = gameObject.AddComponent<AudioSource>();
		AudioSource D3 = gameObject.AddComponent<AudioSource>();
		AudioSource E3 = gameObject.AddComponent<AudioSource>();
		AudioSource F3 = gameObject.AddComponent<AudioSource>();
		AudioSource G3 = gameObject.AddComponent<AudioSource>();
		AudioSource A3 = gameObject.AddComponent<AudioSource>();
		AudioSource B3 = gameObject.AddComponent<AudioSource>();
		AudioSource C4 = gameObject.AddComponent<AudioSource>();

		AudioSource D4 = gameObject.AddComponent<AudioSource>();
		AudioSource E4 = gameObject.AddComponent<AudioSource>();
		AudioSource F4 = gameObject.AddComponent<AudioSource>();
		AudioSource G4 = gameObject.AddComponent<AudioSource>();
		AudioSource A4 = gameObject.AddComponent<AudioSource>();
		AudioSource B4 = gameObject.AddComponent<AudioSource>();
		AudioSource C5 = gameObject.AddComponent<AudioSource>();


		AudioSource Csharp3 = gameObject.AddComponent<AudioSource>();
		AudioSource Dsharp3 = gameObject.AddComponent<AudioSource>();
		AudioSource Fsharp3 = gameObject.AddComponent<AudioSource>();
		AudioSource Gsharp3 = gameObject.AddComponent<AudioSource>();
		AudioSource Asharp3 = gameObject.AddComponent<AudioSource>();

		AudioSource Csharp4= gameObject.AddComponent<AudioSource>();
		AudioSource Dsharp4= gameObject.AddComponent<AudioSource>();
		AudioSource Fsharp4= gameObject.AddComponent<AudioSource>();
		AudioSource Gsharp4= gameObject.AddComponent<AudioSource>();
		AudioSource Asharp4= gameObject.AddComponent<AudioSource>();


		// Spot Light ============================================================================
		C3_Light =  C3_LightObj.GetComponent<Light>();
		C3_Light.enabled = !C3_Light.enabled;

		D3_Light =  D3_LightObj.GetComponent<Light>();
		D3_Light.enabled = !D3_Light.enabled;

		E3_Light =  E3_LightObj.GetComponent<Light>();
		E3_Light.enabled = !E3_Light.enabled;

		F3_Light =  F3_LightObj.GetComponent<Light>();
		F3_Light.enabled = !F3_Light.enabled;

		G3_Light =  G3_LightObj.GetComponent<Light>();
		G3_Light.enabled = !G3_Light.enabled;

		A3_Light =  A3_LightObj.GetComponent<Light>();
		A3_Light.enabled = !A3_Light.enabled;

		B3_Light =  B3_LightObj.GetComponent<Light>();
		B3_Light.enabled = !B3_Light.enabled;

		C4_Light =  C4_LightObj.GetComponent<Light>();
		C4_Light.enabled = !C4_Light.enabled;

		D4_Light =  D4_LightObj.GetComponent<Light>();
		D4_Light.enabled = !D4_Light.enabled;

		E4_Light =  E4_LightObj.GetComponent<Light>();
		E4_Light.enabled = !E4_Light.enabled;

		F4_Light =  F4_LightObj.GetComponent<Light>();
		F4_Light.enabled = !F4_Light.enabled;

		G4_Light =  G4_LightObj.GetComponent<Light>();
		G4_Light.enabled = !G4_Light.enabled;

		A4_Light =  A4_LightObj.GetComponent<Light>();
		A4_Light.enabled = !A4_Light.enabled;

		B4_Light =  B4_LightObj.GetComponent<Light>();
		B4_Light.enabled = !B4_Light.enabled;

		C5_Light =  C5_LightObj.GetComponent<Light>();
		C5_Light.enabled = !C5_Light.enabled;

		Csharp3_Light =  Csharp3_LightObj.GetComponent<Light>();
		Csharp3_Light.enabled = !Csharp3_Light.enabled;

		Dsharp3_Light =  Dsharp3_LightObj.GetComponent<Light>();
		Dsharp3_Light.enabled = !Dsharp3_Light.enabled;

		Fsharp3_Light =  Fsharp3_LightObj.GetComponent<Light>();
		Fsharp3_Light.enabled = !Fsharp3_Light.enabled;

		Gsharp3_Light =  Gsharp3_LightObj.GetComponent<Light>();
		Gsharp3_Light.enabled = !Gsharp3_Light.enabled;

		Asharp3_Light =  Asharp3_LightObj.GetComponent<Light>();
		Asharp3_Light.enabled = !Asharp3_Light.enabled;

		Csharp4_Light =  Csharp4_LightObj.GetComponent<Light>();
		Csharp4_Light.enabled = !Csharp4_Light.enabled;

		Dsharp4_Light =  Dsharp4_LightObj.GetComponent<Light>();
		Dsharp4_Light.enabled = !Dsharp4_Light.enabled;

		Fsharp4_Light =  Fsharp4_LightObj.GetComponent<Light>();
		Fsharp4_Light.enabled = !Fsharp4_Light.enabled;

		Gsharp4_Light =  Gsharp4_LightObj.GetComponent<Light>();
		Gsharp4_Light.enabled = !Gsharp4_Light.enabled;

		Asharp4_Light =  Asharp4_LightObj.GetComponent<Light>();
		Asharp4_Light.enabled = !Asharp4_Light.enabled;

		// Spot Light ============================================================================

		//Audio_Source.clip = Resources.Load("C3") as AudioClip;

		//Audio_Source.Play();
	
		//CNote.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this); // 

		VirtualButtonBehaviour[] vbs = transform.GetComponentsInChildren<VirtualButtonBehaviour> ();

		for (int i=0; i < vbs.Length; ++i) {
			vbs[i].RegisterEventHandler(this);
		}
			

	}
	IEnumerator LateCall(Light spotLight)
	{
		spotLight.enabled = !spotLight.enabled;
		yield return new WaitForSeconds (0.5f);
		spotLight.enabled = !spotLight.enabled;
	}
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		if (vb.name == "CButton") {
//			Debug.Log ("C Note Pressed!!!");
			//AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
			//Audio_Source.clip = Resources.Load("C3") as AudioClip;
			StartCoroutine (LateCall(C3_Light));
			C3.Play ();
			//Audio_Source.Play();
		}

		if (vb.name == "DButton") {
//			Debug.Log ("D Note Pressed!!!");
			StartCoroutine (LateCall(D3_Light));
			D3.Play ();
		}

		if (vb.name == "EButton") {
//			Debug.Log ("E Note Pressed!!!");
			StartCoroutine (LateCall(E3_Light));
			E3.Play ();
		}

		if (vb.name == "FButton") {
//			Debug.Log ("F Note Pressed!!!");
			StartCoroutine (LateCall(F3_Light));
			F3.Play ();
		}

		if (vb.name == "GButton") {
//			Debug.Log ("G Note Pressed!!!");
			StartCoroutine (LateCall(G3_Light));
			G3.Play ();
		}

		if (vb.name == "AButton") {
//			Debug.Log ("A Note Pressed!!!");
			StartCoroutine (LateCall(A3_Light));
			A3.Play ();
		}

		if (vb.name == "BButton") {
//			Debug.Log ("B Note Pressed!!!");
			StartCoroutine (LateCall(B3_Light));
			B3.Play ();
		}

		if (vb.name == "C4Button") {
//			Debug.Log ("C4 Note Pressed!!!");
			StartCoroutine (LateCall(C4_Light));
			C4.Play ();
		}


		if (vb.name == "Csharp3Button") {
			StartCoroutine (LateCall(Csharp3_Light));
//			Debug.Log ("Csharp3 Note Pressed!!!");
			Csharp3.Play ();
		}


		if (vb.name == "Dsharp3Button") {
			StartCoroutine (LateCall(Dsharp3_Light));
//			Debug.Log ("Dsharp3 Note Pressed!!!");
			Dsharp3.Play ();
		}

		if (vb.name == "Fsharp3Button") {
			StartCoroutine (LateCall(Fsharp3_Light));
//			Debug.Log ("Fsharp3 Note Pressed!!!");
			Fsharp3.Play ();
		}


		if (vb.name == "Gsharp3Button") {
			StartCoroutine (LateCall(Gsharp3_Light));
//			Debug.Log ("Gsharp3 Note Pressed!!!");
			Gsharp3.Play ();
		}


		if (vb.name == "Asharp3Button") {
			StartCoroutine (LateCall(Asharp3_Light));
//			Debug.Log ("Asharp3 Note Pressed!!!");
			Asharp3.Play ();
		}
		

		if (vb.name == "D4Button") {
//			Debug.Log ("D4 Note Pressed!!!");
			StartCoroutine (LateCall(D4_Light));
			D4.Play ();
		}

		if (vb.name == "E4Button") {
//			Debug.Log ("E4 Note Pressed!!!");
			StartCoroutine (LateCall(E4_Light));
			E4.Play ();
		}

		if (vb.name == "F4Button") {
//			Debug.Log ("F4 Note Pressed!!!");
			StartCoroutine (LateCall(F4_Light));
			F4.Play ();
		}

		if (vb.name == "G4Button") {
//			Debug.Log ("G4 Note Pressed!!!");
			StartCoroutine (LateCall(G4_Light));
			G4.Play ();
		}

		if (vb.name == "A4Button") {
//			Debug.Log ("A4 Note Pressed!!!");
			StartCoroutine (LateCall(A4_Light));
			A4.Play ();
		}

		if (vb.name == "B4Button") {
//			Debug.Log ("B4 Note Pressed!!!");
			StartCoroutine (LateCall(B4_Light));
			B4.Play ();
		}

		if (vb.name == "C5Button") {
//			Debug.Log ("C5 Note Pressed!!!");
			StartCoroutine (LateCall(C5_Light));
			C5.Play ();
		}


		if (vb.name == "Csharp4Button") {
			StartCoroutine (LateCall(Csharp4_Light));
//			Debug.Log ("Csharp4 Note Pressed!!!");
			Csharp4.Play ();
		}


		if (vb.name == "Dsharp4Button") {
			StartCoroutine (LateCall(Dsharp4_Light));
//			Debug.Log ("Dsharp4 Note Pressed!!!");
			Dsharp4.Play ();
		}

		if (vb.name == "Fsharp4Button") {
			StartCoroutine (LateCall(Fsharp4_Light));
//			Debug.Log ("Fsharp4 Note Pressed!!!");
			Fsharp4.Play ();
		}


		if (vb.name == "Gsharp4Button") {
			StartCoroutine (LateCall(Gsharp4_Light));
//			Debug.Log ("Gsharp4 Note Pressed!!!");
			Gsharp4.Play ();
		}


		if (vb.name == "Asharp4Button") {
			StartCoroutine (LateCall(Asharp4_Light));
//			Debug.Log ("Asharp4 Note Pressed!!!");
			Asharp4.Play ();
		}

		// Song Selection:

		if (vb.name == "Song1_Button") { 
			Debug.Log ("Let's learn to play Happy Birthday to you! ");



		}


		if (vb.name == "Song2_Button") { 
			Debug.Log ("Let's learn to play Mary had a little lamb! ");
		}
	}

			// for (int =0; i<arraylength;i++)
			//{
			//AudioClip[i].play;
			//if 
			//}


	


	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		//Debug.Log ("C Note released");
//		if(vb.name=="CButton") 
//		{ Debug.Log ("C Note Released!!!");
//			C3_Light.enabled = !C3_Light.enabled;
//			C3.Stop();
//		}
//
//		if(vb.name=="DButton") 
//		{ Debug.Log ("D Note Released!!!");
//			D3.Stop();
//		}
//
//
//		if(vb.name=="EButton") 
//		{ Debug.Log ("E Note Released!!!");
//			E3.Stop();
//		}
//
//		if(vb.name=="FButton") 
//		{ Debug.Log ("F Note Released!!!");
//			F3.Stop();
//		}
//
//
//		if(vb.name=="AButton") 
//		{ Debug.Log ("A Note Released!!!");
//			A3.Stop();
//		}
//
//		if(vb.name=="BButton") 
//		{ Debug.Log ("B Note Released!!!");
//			B3.Stop();
//		}
//


	}


}
