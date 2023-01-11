using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    // Array of game objects that are involved in the cutscene 
    public GameObject[] actors;

    // Array of animation clips to be played on the actors 
    public AnimationClip[] animations;

    // Function to start the cutscene 
    public void PlayCutscene()
    {
        // Loop through the actors and play the corresponding animation 
        for (int i = 0; i < actors.Length; i++)
        {
            Animator animator = actors[i].GetComponent<Animator>();
            animator.Play(animations[i].name);
        }
    }
}
