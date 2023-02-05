using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    [SerializeField]
    Image BlackFade;

    int timeline = 0;
    enum Cmd 
    {
        nothing,
        powerUnstable,
        fadeIn,
        fadeOut
    };
    Cmd cmd;

    private void Start()
    {
        FadeIn();
    }

    private void FixedUpdate()
    {
        switch (cmd)
        {
            case Cmd.nothing:
                BlackFade.enabled = false;
                break;
            case Cmd.powerUnstable:
                BlackFade.enabled = true;
                if (timeline > 40)
                    BlackFade.color = new Color(0, 0, 0, 0.7f);
                else if (timeline > 30)
                    BlackFade.color = new Color(0, 0, 0, 0.3f);
                else if (timeline > 20)
                    BlackFade.color = new Color(0, 0, 0, 0.2f);
                else if (timeline > 1)
                    BlackFade.color = new Color(0, 0, 0, 0.1f);
                else
                {
                    BlackFade.enabled = false;
                    cmd = Cmd.nothing;
                }
                timeline--;
                break;
            case Cmd.fadeIn:
                BlackFade.enabled = true;

                BlackFade.color = new Color(0, 0, 0, timeline * 1f / 20);

                if(timeline == 0)
                {
                    BlackFade.enabled = false;
                    cmd = Cmd.nothing;
                }
                timeline--;
                break;
        }
    }

    public void PowerOff()
    {
        cmd = Cmd.powerUnstable;
        timeline = 50;
    }

    public void FadeIn()
    {
        cmd = Cmd.fadeIn;
        timeline = 20;
    }
}
