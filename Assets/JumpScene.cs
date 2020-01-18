using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    // Start is called before the first frame update
    
public string nextScene;

private void SceneJump(){
 SceneManager.LoadSceneAsync(nextScene);
}

private void OnCollisionEnter(Collision other)
{
    
}
}
