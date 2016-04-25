using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour {
   public void SceneSelect(int scene)
    {

        SceneManager.LoadScene(scene);


    } 
      
    void Start () {
	
	}
	
	
	void Update () {
	
	}
}
