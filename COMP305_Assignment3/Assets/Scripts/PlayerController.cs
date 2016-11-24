using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    //Christopher Gelinas 300844877 COMP305 Assignment3 Part2


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Paper"))
        {
            SceneManager.LoadScene("Winner");
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }

    }
    }
