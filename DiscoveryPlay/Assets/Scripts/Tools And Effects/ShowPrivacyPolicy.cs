using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowPrivacyPolicy : MonoBehaviour{

	public void Link(){
		Application.OpenURL("https://github.com/tingzhb/DiscoveryPlay/blob/main/DiscoveryPlayPrivacyPolicy.md");
	}
}
