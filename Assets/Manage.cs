using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Manage : MonoBehaviour
{
    public string flatUrl;
    public string immersiveUrl;
    public VideoPlayer player;
    public void Immersive()
    {
        player.url= immersiveUrl;
    }
    public void Flat()
    {
        player.url = flatUrl;
    }
}
