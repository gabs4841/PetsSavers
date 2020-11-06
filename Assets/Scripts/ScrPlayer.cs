using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour {

    private Rigidbody2D corpo;
    public LayerMask camadachao;
    public Transform objpe;
    public bool nochao = true;
    private float raiope = .2f;
    public float forcapulo = 25f;

    void Start() {
        corpo = GetComponent<Rigidbody2D>();
    }

    void Update() {
        nochao = Physics2D.OverlapCircle(objpe.position, raiope, camadachao);
    }

    public void Pular(){
        if (nochao)
        {
            corpo.AddForce(new Vector2(0f, forcapulo), ForceMode2D.Impulse);
        }
    }
}
