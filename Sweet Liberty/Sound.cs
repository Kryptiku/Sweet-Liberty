﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


public class Sound
{ 
    public static void PlaySoundEffect(string filepath)
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        soundPlayer.SoundLocation = filepath;
        soundPlayer.Play();
    }
}
