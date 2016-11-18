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
	private GameObject Csharp3Button;
	private GameObject Dsharp3Button;
	private GameObject Fsharp3Button;
	private GameObject Gsharp3Button;
	private GameObject Asharp3Button;
	public AudioSource C3;
	public AudioSource D3;
	public AudioSource E3;
	public AudioSource F3;
	public AudioSource G3;
	public AudioSource A3;
	public AudioSource B3;
	public AudioSource C4;
	public AudioSource Csharp3;
	public AudioSource Dsharp3;
	public AudioSource Fsharp3;
	public AudioSource Gsharp3;
	public AudioSource Asharp3;
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

		Csharp3Button = GameObject.Find ("Csharp3Button");  // Finds the Virtual Button Object
		Dsharp3Button = GameObject.Find ("Dsharp3Button");  // Finds the Virtual Button Object
		Fsharp3Button = GameObject.Find ("Fsharp3Button");  // Finds the Virtual Button Object
		Gsharp3Button = GameObject.Find ("Gsharp3Button");  // Finds the Virtual Button Object
		Asharp3Button = GameObject.Find ("Asharp3Button");  // Finds the Virtual Button Object


		AudioSource C3 = gameObject.AddComponent<AudioSource>();
		AudioSource D3 = gameObject.AddComponent<AudioSource>();
		AudioSource E3 = gameObject.AddComponent<AudioSource>();
		AudioSource F3 = gameObject.AddComponent<AudioSource>();
		AudioSource G3 = gameObject.AddComponent<AudioSource>();
		AudioSource A3 = gameObject.AddComponent<AudioSource>();
		AudioSource B3 = gameObject.AddComponent<AudioSource>();
		AudioSource C4 = gameObject.AddComponent<AudioSource>();

		AudioSource Csharp3= gameObject.AddComponent<AudioSource>();
		AudioSource Dsharp3= gameObject.AddComponent<AudioSource>();
		AudioSource Fsharp3= gameObject.AddComponent<AudioSource>();
		AudioSource Gsharp3= gameObject.AddComponent<AudioSource>();
		AudioSource Asharp3= gameObject.AddComponent<AudioSource>();



		//Audio_Source.clip = Resources.Load("C3") as AudioClip;

		//Audio_Source.Play();
	
		//CNote.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this); // 

		VirtualButtonBehaviour[] vbs = transform.GetComponentsInChildren<VirtualButtonBehaviour> ();

		for (int i=0; i < vbs.Length; ++i) {
			vbs[i].RegisterEventHandler(this);
		}



	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		if(vb.name=="CButton") 
		{ Debug.Log ("C Note Pressed!!!");
			//AudioSource Audio_Source = gameObject.AddComponent<AudioSource>();
			//Audio_Source.clip = Resources.Load("C3") as AudioClip;
			C3.Play();
			//Audio_Source.Play();
		}

		if(vb.name=="DButton") 
		{ Debug.Log ("D Note Pressed!!!");
			D3.Play();
		}

		if(vb.name=="EButton") 
		{ Debug.Log ("E Note Pressed!!!");
			E3.Play();}

		if(vb.name=="FButton") 
		{ Debug.Log ("F Note Pressed!!!");
			F3.Play();}

		if(vb.name=="GButton") 
		{ Debug.Log ("G Note Pressed!!!");
			G3.Play();}

		if(vb.name=="AButton") 
		{ Debug.Log ("A Note Pressed!!!");
			A3.Play();}

		if(vb.name=="BButton") 
		{ Debug.Log ("B Note Pressed!!!");
			B3.Play();}

		if(vb.name=="C4Button") 
		{ Debug.Log ("C4 Note Pressed!!!");
			C4.Play();}


		if(vb.name=="Csharp3Button") 
		{ Debug.Log ("Csharp3 Note Pressed!!!");
			Csharp3.Play();}


		if(vb.name=="Dsharp3Button") 
		{ Debug.Log ("Dsharp3 Note Pressed!!!");
			Dsharp3.Play();}

		if(vb.name=="Fsharp3Button") 
		{ Debug.Log ("Fsharp3 Note Pressed!!!");
			Fsharp3.Play();}


		if(vb.name=="Gsharp3Button") 
		{ Debug.Log ("Gsharp3 Note Pressed!!!");
			Gsharp3.Play();}


		if(vb.name=="Asharp3Button") 
		{ Debug.Log ("Asharp3 Note Pressed!!!");
			Asharp3.Play();}
		

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		//Debug.Log ("C Note released");
//		if(vb.name=="CButton") 
//		{ Debug.Log ("C Note Released!!!");
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
