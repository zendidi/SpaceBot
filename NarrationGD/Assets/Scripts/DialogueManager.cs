using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text DialogueText;

    private Queue<Sentence> Sentences;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<Sentence>();
    }

    public void StartDialogue (Dialogue dialogue)
       {
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;
        Sentences.Clear();

        foreach(Sentence sentence in dialogue.sentences)
        {        
         Sentences.Enqueue(sentence);          
        }

        DisplayNextSentence();
       }

    public void DisplayNextSentence()
    {
        if (Sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        Sentence sentence = Sentences.Dequeue();
        if (sentence.phrase=="")
        {
            sentence.Action.Invoke();
            EndDialogue();
            return;
        }

        if (sentence.phrase.ToCharArray()[0] == '0')
        {
         sentence.Action.Invoke();
        }

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence.phrase));
        
    }
    
    IEnumerator TypeSentence(string sentence)
    {
        DialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
