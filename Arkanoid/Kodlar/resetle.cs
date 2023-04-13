using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetle : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene("arkanoid");
    }
}
