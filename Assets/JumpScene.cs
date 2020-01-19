using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    // Start is called before the first frame update

    public string nextScene;

    private void SceneJump()
    {
        SceneManager.LoadSceneAsync(nextScene);
    }

    private void Update()
    {
        if (CastUp())
        {
            Debug.Log("Player go to the destination");
            SceneJump();
        }
    }

    private bool CastUp()
    {
        Ray upDec=new Ray(transform.position,Vector3.up);
        RaycastHit rayHit;
        if (Physics.Raycast(upDec, out rayHit))
        {
            Debug.Log("DecObj is:"+rayHit.transform.gameObject.name);
            if (rayHit.transform.parent.gameObject.name == GameManager.instance.player.name)
            {
                
                return true;
            }
        }

        return false;
    }
}