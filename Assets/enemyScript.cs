using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyScript : MonoBehaviour
{
    public float delayBeforeGameOver = 1.0f;
    GameObject player;
    private Animator animator;
    bool screaming;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.Find("Player");
        screaming = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.transform.position)<25 && screaming == false)
        {
            screaming = true;
            GetComponent<AudioSource>().Play();

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Player"))
        {
            animator.Play("Attack");
            StartCoroutine(DelayedGameOver());
        }
    }

    IEnumerator DelayedGameOver()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeGameOver);

        // Load the GameOver scene after the delay
        SceneManager.LoadScene("GameOver");
    }
}
