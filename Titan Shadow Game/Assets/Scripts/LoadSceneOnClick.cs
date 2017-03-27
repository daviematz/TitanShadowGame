using UnityEngine;
using System.Collections;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int index)
    {
        if(index == -1)
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
        else
            Application.LoadLevel(index);
    }
}
