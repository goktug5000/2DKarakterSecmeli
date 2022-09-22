using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseOne : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Kolay;
    public CharMove PlayerRN;
    public float CSpeed, CHp, CmaxHp, CJumpPow;
    public int CMaxJump;
    public Text adim, genelAciklama, stats, skills;
    void Start()
    {
        PlayerRN = GameObject.Find("Player").GetComponent<CharMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Zenci()
    {
        CSpeed = 15;
        CmaxHp = 10;
        CHp = 10;
        CJumpPow = 20;
        CMaxJump = 2;

        adim.text = "Zenci";
        genelAciklama.text = "Fiziken güçlü geçen ay köleydi.\n1 yerine 2 hoplar.";
        stats.text = "Hız= " + CSpeed.ToString() + "\n"
                    +"Max Can= "+CmaxHp.ToString()+"\n"
                    +"Zıplama Gücü= "+CJumpPow.ToString()+"\n"
                    ;


    }
    public void Beyaz()
    {
        CSpeed = 10;
        CmaxHp = 10;
        CHp = 10;
        CJumpPow = 10;
        CMaxJump = 1;

        adim.text = "Beyaz";
        genelAciklama.text = "Eskiden bir çiftçiydi.\nDiğerlerine göre daha zeki.";
        stats.text = "Hız= " + CSpeed.ToString() + "\n"
                    + "Max Can= " + CmaxHp.ToString() + "\n"
                    + "Zıplama Gücü= " + CJumpPow.ToString() + "\n"
                    ;


    }

    public void Sec()
    {
        //PlayerRN.ReCreate(speed, maxHP, HP,JumpPow);
        PlayerRN.ReCreate(CSpeed, CmaxHp, CHp, CJumpPow, CMaxJump);
    }
}
