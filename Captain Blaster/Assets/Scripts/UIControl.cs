using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    public Image controls, credits;
    public Text X, A, controlsButtonText;
    public Button Y, B, controlsButton;

	public void Play() {
        Application.LoadLevel(1);
	}
	
	public void Exit() {
        Application.Quit();
	}

    public void ShowControls(){
        controls.enabled = true;
        X.enabled = true;
        Y.image.enabled = true;
    }

    public void HideControls(){
        controls.enabled = false;
        X.enabled = false;
        Y.image.enabled = false;
    }

    public void ShowCredits(){
        credits.enabled = true;
        A.enabled = true;
        B.image.enabled = true;
        controlsButtonText.enabled = false;
        controlsButton.image.enabled = false;
    }

    public void HideCredits(){
        credits.enabled = false;
        A.enabled = false;
        B.image.enabled = false;
        controlsButtonText.enabled = true;
        controlsButton.image.enabled = true;
    }
}
