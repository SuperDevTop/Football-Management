using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using System.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using SFB;

public class LoadTexture : MonoBehaviour
{
    string path;

    public void Upload()
    {
        #if UNITY_EDITOR
                path = EditorUtility.OpenFilePanel("Select your background.", "", "");
#else
                 var paths = StandaloneFileBrowser.OpenFilePanel("Select your background.", "", "",false);
            path = paths[0];
#endif

        if (path.Length != 0)
        {
            //var fileContent = File.ReadAllBytes(path);
            StartCoroutine("LoadImage");           
        }
    }

    IEnumerator LoadImage()
    {
        WWW www = new WWW(path);
        while (!www.isDone)
            yield return null;        
        this.GetComponent<RawImage>().texture = www.texture;
    }
}
